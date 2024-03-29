using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject spawner;
    public GameObject gameUI;
    public GameObject titleScreen;
    public GameObject endScreen;
    public Button startButton;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public GameObject moleception;
    public GameObject background;
    private int score;
    private int lives;
    public AudioSource audioSource;
    public AudioClip spawnSound;
    public AudioClip hitSound;
    public AudioClip leaveSound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        background.SetActive(false);
        moleception.SetActive(true);
        endScreen.SetActive(false);
        gameUI.SetActive(false);
        titleScreen.SetActive(true);
        lives = 3;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        titleScreen.SetActive(false);
        moleception.SetActive(false);
        background.SetActive(true);
        gameUI.SetActive(true);
        spawner.GetComponent<MoleSpawner>().isPlaying = true;
        spawner.GetComponent<MoleSpawner>().RemoteSpawn();
    }

    public void UpdateScore(int addedScore)
    {
        score += addedScore;
        scoreText.text = $"Score: {score}";
    }

    public void UpdateLives(int livesRemoved)
    {
        lives -= livesRemoved;
        livesText.text = $"Lives: {lives}";
        
        if (lives == 0)
        {
            spawner.GetComponent<MoleSpawner>().isPlaying = false;
            endScreen.SetActive(true);
        }
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
