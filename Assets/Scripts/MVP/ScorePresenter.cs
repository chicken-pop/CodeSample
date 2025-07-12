public class ScorePresenter
{
    private ScoreModel _ScoreModel;
    private ScoreView _ScoreView;

    public ScorePresenter(ScoreModel scoreModel, ScoreView scoreView)
    {
        _ScoreModel = scoreModel;
        _ScoreView = scoreView;
    }

    public void initialize()
    {
        _ScoreModel.initialize();
        _ScoreView.initialize();

        bind();
    }

    public void setup()
    {
        // Additional setup if needed
    }

    public void bind()
    {
        _ScoreModel.OnScoreChanged += _ScoreView.updateScoreText;
    }

    public void unbind()
    {
        _ScoreModel.OnScoreChanged -= _ScoreView.updateScoreText;
    }

}
