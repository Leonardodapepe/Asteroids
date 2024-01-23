using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public static Score instance;
    [SerializeField]  public TextMeshProUGUI scoreText;
     private int score;

     private void Awake(){
       instance = this;
     }

    private void Start() {
        scoreText.text = score.ToString();
        scoreText.text = score.ToString() + " points";
    }

    public void UpdateScore() {
        score += 1;
        scoreText.text = score.ToString() + " points";
    }
}