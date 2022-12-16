using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public Text scoreText;
    public float scrollSpeed = -1.5f;



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

    }

    public void BirdScored()
    {

        if (gameOver)
            return;
        score++;

        scoreText.text = "Score: " + score.ToString();
    }
}
