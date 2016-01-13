using UnityEngine;
using System.Collections;

public class SelectLevel : MonoBehaviour {

	[SerializeField]
	private GameObject selectPuzzleMenuPanel, puzzleLevelSelectPanel;

	[SerializeField]
	private Animator selectPuzzleMenuAnim, puzzleLevelSelectAnim;

	private string selectedPuzzle;

	public void BackToPuzzleSelecetMenu() {
		StartCoroutine (ShowPuzzleSelectMenu ());
	}

	IEnumerator ShowPuzzleSelectMenu() {
		selectPuzzleMenuPanel.SetActive (true);
		selectPuzzleMenuAnim.Play ("Slidein");
		puzzleLevelSelectAnim.Play ("Slideout");

		yield return new WaitForSeconds (1f);
		puzzleLevelSelectPanel.SetActive (false);
	}
}
