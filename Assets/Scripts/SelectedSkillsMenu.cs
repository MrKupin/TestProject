using UnityEngine;

public class SelectedSkillsMenu : MonoBehaviour
{
    [SerializeField] private Transform selectedSkillMenuTopPoint;
    [SerializeField] private Transform selectedSkillMenuDownPoint;
    private bool isEditing;

    public void StartEditing()
    {
        isEditing = true;
        SetPosition();
    }

    public void FinishEditing()
    {
        isEditing = false;
        SetPosition();
    }

    public void SetPosition()
    {
        transform.position = isEditing ? selectedSkillMenuTopPoint.position :
                                                selectedSkillMenuDownPoint.position;
    }
}
