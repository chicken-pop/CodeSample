using System;

public class ScoreModel
{
    public event Action<int> OnScoreChanged;

    private int _Score;
    public int Score => _Score;
    /*
    public int Score
    {
        get => _Score;
        set
        {
            _Score = value;
            OnScoreChanged?.Invoke(_Score);
        }
    }
    */

    public void initialize()
    {
        setScore(0);
    }

    public void setup()
    {
        // Additional setup if needed
    }

    public void addScore()
    {
        _Score++;
        OnScoreChanged?.Invoke(_Score);
    }

    public void setScore(int score)
    {
        _Score = score;
    }

}
