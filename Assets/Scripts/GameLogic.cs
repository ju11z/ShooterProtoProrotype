using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public int score;
    public Text scoreField;

    public Text healthField;

    public void UpdateScore()
    {
        score++;
        scoreField.text = "Score :" + score.ToString();
        //Debug.Log("Очки обновлены!!!");
    }

    public void UpdateHealth(int health)
    {
        healthField.text = "Health :" + health.ToString();
    }

}
