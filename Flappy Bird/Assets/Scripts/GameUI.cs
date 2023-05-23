using TMPro;

using UnityEngine;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TextMeshProUGUI _scoretext;
    [SerializeField] private GameObject _gameOver;
    [SerializeField] private GameObject _playbutton;
    private int _score;

    private void Awake()
    {
        Application.targetFrameRate = 60;

        Pause();
    }

    public void GameOver()
    {
        _gameOver.SetActive(true);
        _playbutton.SetActive(true);
        
        Pause();
    }

    public void IncreaseScore()
    {
        _score++;
        _scoretext.text = _score.ToString();
    }

    private void Pause()
    {
        Time.timeScale = 0f;
        _player.enabled = false;
    }

    public void Play()
    {
        _score = 0;
        _scoretext.text = _score.ToString();
        
        _gameOver.SetActive(false);
        _playbutton.SetActive(false);

        Time.timeScale = 1f;
        _player.enabled = true;

        Pipes[] pipes = FindObjectsOfType <Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
}