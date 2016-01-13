using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class LayoutPuzzleButtons : MonoBehaviour {

    [SerializeField]
    public Transform puzzleLevel1, puzzleLevel2, puzzleLevel3, puzzleLevel4, puzzleLevel5;

    public List<Button> level1Buttons, level2Buttons, level3Buttons, level4Buttons, level5Buttons;

    public List<Animator> level1Anims, level2Anims, level3Anims, level4Anims, level5Anims;

    [SerializeField]
    private Sprite[] puzzleButtonsBacksideImage;

    private int puzzleLevel;

    private string selectedPuzzle;

    public void LayoutButtons(int level, string puzzle) {
        this.puzzleLevel = level;
        this.selectedPuzzle = puzzle;

        LayoutPuzzle();
    }

    void LayoutPuzzle() {
        switch (puzzleLevel) {
            case 0:
                foreach (Button btn in level1Buttons) {
                    if (btn.gameObject.activeInHierarchy) {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(puzzleLevel1, false);
                    }
                }
                break;
            default:
                break;
        }
    }    
}
