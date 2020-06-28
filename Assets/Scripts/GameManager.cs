using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text energyText;
    public Text bombText;
    public Text scoreText;
    int energy = 100;
    int bombAmmo = 3;
    int score = 0;
    private void Start()
    {
        energyText.text = "Energy: " + energy.ToString();
        bombText.text = "Bombs: " + bombAmmo.ToString();
        scoreText.text = "Score: " + score.ToString();
    }
    void Update()
    {
        
    }
}
