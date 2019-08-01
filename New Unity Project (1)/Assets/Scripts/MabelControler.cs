using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class MabelControler : MonoBehaviour , IDragHandler,IPointerUpHandler,IPointerDownHandler
{
    public Image JoystickBG;
    public Image Joystick;
    private Vector2 InputVector;// получение координат джойстика

    void Start()
    {
        JoystickBG = GetComponent<Image>();
        Joystick = transform.GetChild(0).GetComponent<Image>();
    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        InputVector = Vector2.zero;
        Joystick.rectTransform.anchoredPosition = Vector2.zero; // возрат джойстика в центр
    }
    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(JoystickBG.rectTransform,ped.position,ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / JoystickBG.rectTransform.sizeDelta.x);// получение координат позициии на джойстик
            pos.y = (pos.y / JoystickBG.rectTransform.sizeDelta.y);// получение координат позициии на джойстик
            
            InputVector = new Vector2(pos.x * 2 - 1, pos.y * 2 - 1);//утановка точных координат из косания 
            InputVector = (InputVector.magnitude > 1.0f) ? InputVector.normalized : InputVector;

            Joystick.rectTransform.anchoredPosition = new Vector2(InputVector.x * (JoystickBG.rectTransform.sizeDelta.x / 2), InputVector.y * (JoystickBG.rectTransform.sizeDelta.y / 2));
        }
    }
    public float Horizontal()
    {
        if (InputVector.x != 0) return InputVector.x;
        else return Input.GetAxis("Horizontal");
    }
    public float Vertical()
    {
        if (InputVector.y != 0) return InputVector.y;
        else return Input.GetAxis("Vertical");
    }
}
