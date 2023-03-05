using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    // Start is called before the first frame update
    public int score=0;

    public void IncreaseScore(int amount)
    {
        score += amount;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
