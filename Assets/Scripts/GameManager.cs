using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    static GameManager instance = null;
    public static GameManager Get()
    {
        return instance;
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        Player.die += Die;
    }
    void Update()
    {
        
    }
    void Die()
    {
        SceneManager.LoadScene("End");
        ResetValues();
    }
    public void ResetValues()
    {
        score = 0;
    }
    private void OnDisable()
    {
        Player.die -= Die;
    }

}
