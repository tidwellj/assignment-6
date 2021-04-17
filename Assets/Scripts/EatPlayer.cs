using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EatPlayer : MonoBehaviour
{
    public static int lives = 3;
    public Text text;
   // public static bool won = false;
    private void Update()
    {
        text.text = lives.ToString();

    }
    void OnTriggerEnter(Collider col)
    {


        if (col.tag == "Player")
        {
            
           // Destroy(this.gameObject);
            text.text = lives.ToString();
            lives = lives - 1;

            Debug.Log(lives);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            BallCollide.score = 0;

        }
        if (lives == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //won = false;
            BallCollide.score = 0;
        }

    }

}