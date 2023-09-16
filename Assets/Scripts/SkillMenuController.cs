using UnityEngine;
using UnityEngine.UI;

public class SkillMenuController : MonoBehaviour
{
    [SerializeField] private SelectedSkillsMenu selectedSkillsMenu;
    [SerializeField] private SkillSelectionMenu skillSelectionMenu;
    [SerializeField] private Button skillSelectionStartButton;
    [SerializeField] private Button skillSelectionCompletionButton;

    private void Start()
    {
        selectedSkillsMenu.FinishEditing();
        skillSelectionMenu.Disable();
        skillSelectionStartButton.gameObject.SetActive(true);
        skillSelectionCompletionButton.gameObject.SetActive(false);
    }

    public void StartSkillSelection()
    {
        skillSelectionStartButton.gameObject.SetActive(false);
        skillSelectionCompletionButton.gameObject.SetActive(true);
        skillSelectionMenu.Activate();
        selectedSkillsMenu.StartEditing();
    }

    public void CompleteSkillSelection()
    {
        skillSelectionStartButton.gameObject.SetActive(true);
        skillSelectionCompletionButton.gameObject.SetActive(false);
        skillSelectionMenu.Disable();
        selectedSkillsMenu.FinishEditing();
    }
}
