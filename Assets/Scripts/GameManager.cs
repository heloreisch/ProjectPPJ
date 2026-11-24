
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;

    [Header("Jogador")]
    public GameObject player;

    public enum gameStates
    {
        Playing,
        GameOver,
        BeatLevel
    }

    [Header("Estado do jogo")]
    public gameStates gameState = gameStates.Playing;

    [Header("Pontuação")]
    public int score = 0;
    public GameObject mainCanvas;
    public TMP_Text mainScoreDisplay;

    [Header("Telas")]
    public GameObject gameOverCanvas;
    public TMP_Text gameOverScoreDisplay;
    public GameObject beatLevelCanvas;

    [Header("Música")]
    public AudioSource backgroundMusic;

    void Awake()
    {
        gm = this;
    }

    void Start()
    {
        gameState = gameStates.Playing;

        if (mainCanvas != null)
            mainCanvas.SetActive(true);

        if (gameOverCanvas != null)
            gameOverCanvas.SetActive(false);

        if (beatLevelCanvas != null)
            beatLevelCanvas.SetActive(false);

        if (backgroundMusic != null)
        {
            backgroundMusic.loop = true;
            backgroundMusic.Play();
        }

        Collect(0);
    }

    public void Collect(int amount)
    {
        score += amount;

        if (mainScoreDisplay != null)
            mainScoreDisplay.text = score.ToString();
    }

    public void GameOver()
    {
        if (gameState != gameStates.Playing)
            return;

        gameState = gameStates.GameOver;

        if (gameOverScoreDisplay != null && mainScoreDisplay != null)
            gameOverScoreDisplay.text = mainScoreDisplay.text;

        if (mainCanvas != null)
            mainCanvas.SetActive(false);

        if (gameOverCanvas != null)
            gameOverCanvas.SetActive(true);

        if (backgroundMusic != null)
            backgroundMusic.Stop();

        if (player != null)
            player.SetActive(false);
    }

    public void CompleteLevel()
    {
        if (gameState != gameStates.Playing)
            return;

        gameState = gameStates.BeatLevel;

        if (mainCanvas != null)
            mainCanvas.SetActive(false);

        if (beatLevelCanvas != null)
            beatLevelCanvas.SetActive(true);

        if (backgroundMusic != null)
            backgroundMusic.Stop();

        if (player != null)
            player.SetActive(false);
    }
}
