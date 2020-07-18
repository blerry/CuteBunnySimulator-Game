using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoringSystem: MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore = 0;

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Carrots: " + theScore + "/8";
        Winner();
    }
    void Winner()
    {
        if(theScore == 8)
        {
            Debug.Log("SCORE EQUALS 1");
            theScore = 0;
            SceneManager.LoadScene("Win");
            
        }
    }
}
