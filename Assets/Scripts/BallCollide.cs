using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallCollide : MonoBehaviour
{   public static int score = 0;
    public Text text;
    public static bool won = false;
    private void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
       
        
            if (col.tag == "Player")
            {
                Destroy(this.gameObject);
                score = score + 10;
                text.text = score.ToString();

                Debug.Log(score);
            }
        if (score == 30)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            won = true;

        }

    }

}