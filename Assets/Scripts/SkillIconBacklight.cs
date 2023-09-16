using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SkillIconBacklight : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Image backlight;

    private void Start()
    {
        backlight.enabled = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        backlight.enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        backlight.enabled = false;
    }
}
