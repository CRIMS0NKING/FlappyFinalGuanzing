using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject GameOverText;
    public TMP_Text scoreText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    private int score = 0;



    // Start is called before the first frame update
    void Awake()
    {

        if (instance == null)

            instance = this;

        else if (instance != this)

            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    public void BirdScored()
    {

        if (gameOver)
            return;
        score++;

        scoreText.text = "Score: " + score.ToString();
    }

    public void BirdDied()
    {
        GameOverText.SetActive(true);

        gameOver = true;
    }
}

