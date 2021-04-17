using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayAgain : MonoBehaviour
{
    private void Start()
    {
        if (BallCollide.won == true)
        {
            text.text = "You won with 30 points";
        }
        else
            text.text = "You lost";
    }
    public Text text;
    // Start is called before the first frame update
    public void PlayAnother()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        BallCollide.won = false;
        BallCollide.score = 0;
        EatPlayer.lives = 3;
    }

    public void ExitGame()
    {
        Application.Quit();

    }
}
