using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField]    // [Datamember]と同じ
    private TextMeshProUGUI _ScoreText;

    public void initialize()
    {
        updateScoreText(0);
    }

    public void setup()
    {
        // Additional setup if needed
    }

    /// <summary>
    /// スコアのテキストを更新
    /// </summary>
    /// <param name="value"></param>
    public void updateScoreText(int value)
    {
        _ScoreText.text = value.ToString();
    }
}
