using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] TMP_Text scoreBoardText;
    public int score = 0;

    public void increaseScore(int amount) {
        score += amount;
        scoreBoardText.text = score.ToString();
    }
}
