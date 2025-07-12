using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField]    // [Datamember]�Ɠ���
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
    /// �X�R�A�̃e�L�X�g���X�V
    /// </summary>
    /// <param name="value"></param>
    public void updateScoreText(int value)
    {
        _ScoreText.text = value.ToString();
    }
}
