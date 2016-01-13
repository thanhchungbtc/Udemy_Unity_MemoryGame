using UnityEngine;
using System.Collections;

public class SettingController : MonoBehaviour {

	[SerializeField]
	private GameObject settingPanel;

	[SerializeField]
	private Animator settingPanelAnim;

	public void OpenSettingPanel() {
		settingPanel.SetActive (true);
		settingPanelAnim.Play ("Slidein");
	}


	public void CloseSettingPanel() {
		StartCoroutine (CloseSettings ());
	}

	IEnumerator CloseSettings() {
		settingPanelAnim.Play ("Slideout");
		yield return new WaitForSeconds (1f);
		settingPanel.SetActive (false);
	}
}
