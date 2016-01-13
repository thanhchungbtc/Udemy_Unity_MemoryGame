using UnityEngine;
using System.Collections;

public class SelectLevel : MonoBehaviour {

    [SerializeField]
    private LoadPuzzleGame loadPuzzleGame;

	[SerializeField]
	private GameObject selectPuzzleMenuPanel, puzzleLevelSelectPanel;

	[SerializeField]
	private Animator selectPuzzleMenuAnim, puzzleLevelSelectAnim;

	private string selectedPuzzle;

	public void BackToPuzzleSelecetMenu() {
		StartCoroutine (ShowPuzzleSelectMenu ());
	}

    public void SelectPuzzleLevel() {
        int level = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        loadPuzzleGame.LoadPuzzle(level, selectedPuzzle);
    }

	IEnumerator ShowPuzzleSelectMenu() {
		selectPuzzleMenuPanel.SetActive (true);
		selectPuzzleMenuAnim.Play ("Slidein");
		puzzleLevelSelectAnim.Play ("Slideout");

		yield return new WaitForSeconds (1f);
		puzzleLevelSelectPanel.SetActive (false);
	}

    public void SetSelectedPuzzle(string selectedPuzzle) {
        this.selectedPuzzle = selectedPuzzle;
        Debug.Log("Selected Puzzle: " + selectedPuzzle);
    }
}
