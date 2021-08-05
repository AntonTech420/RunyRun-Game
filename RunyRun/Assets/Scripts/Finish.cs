using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public Score theHighScore;
    float time = 0;

    void FixedUpdate(){
        time += 0.02f;
    }

    void OnTriggerEnter(Collider other) {
        theHighScore.SetHighScore(time);
        if(other.tag == "Player"){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if(other.tag == "Player1"){
        SceneManager.LoadScene("BlueWin");
        }
        if(other.tag == "Player2"){
        SceneManager.LoadScene("GoldWin");
        }
    }
}