using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private ScoreView _ScoreView;
    private ScoreModel _ScoreModel;
    private ScorePresenter _ScorePresenter;
    public ScorePresenter ScorePresenter => _ScorePresenter;

    public void Start()
    {
        _ScoreModel = new ScoreModel();
        _ScorePresenter = new ScorePresenter(_ScoreModel, _ScoreView);
        _ScorePresenter.initialize();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _ScoreModel.addScore();
        }
    }

    private void OnDestroy()
    {
        // ScoreViewÇÊÇËGameManagerÇÃÅZÅZÅZÇè¨Ç≥Ç≠Ç∑ÇÈ
        _ScorePresenter.unbind();
    }
}

