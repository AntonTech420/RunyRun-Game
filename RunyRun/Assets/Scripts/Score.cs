using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    float time = 0;
    float bestTime = 9999;

    private void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        bestTime = PlayerPrefs.GetFloat("bestTime", 0);
        highScoreText.text = "Best Time: " + bestTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // time += 1 * Time.deltaTime;
        // scoreText.text = "Time: " + time;
        
        // if(bestTime > time)
        // PlayerPrefs.SetFloat("bestTime", 999);
    }
    public void SetHighScore(float BestScore){
        if(bestTime > BestScore)
        PlayerPrefs.SetFloat("bestTime", BestScore);
    }
    void FixedUpdate(){
        time += 0.02f;
        scoreText.text = "Time: " + time;
    }
}