using UnityEngine;

public class SkillSelectionMenu : MonoBehaviour
{
    [SerializeField] private Vector3 activeState = new Vector3(1, 1, 1);

    public void Activate()
    {
        transform.localScale = activeState;
    }

    public void Disable()
    {
        transform.localScale = new Vector3();
    }
}
