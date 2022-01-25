using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    
    public Text playerScoreText;
    public Text computerScoreText;

    private float _playerScoreValue;
    private float _computerScoreValue;

    public void PlayerScore()
    {
        _playerScoreValue++;
        playerScoreText.text = _playerScoreValue.ToString();
        ResetRound();
    }
    public void ComputerScore()
    {
        _computerScoreValue++;
        computerScoreText.text = _computerScoreValue.ToString();
        ResetRound();
    }
    private void ResetRound()
    {
        ball.ResetPosition();
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
    }
}
