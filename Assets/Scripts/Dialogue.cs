using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [SerializeField] TMP_Text dialogueText;
    [SerializeField] string[] timelineTextLine;

    private int currentline = 0;

    public void nextDialogueLine() {
        currentline++;
        dialogueText.text = timelineTextLine[currentline];
    }
}
