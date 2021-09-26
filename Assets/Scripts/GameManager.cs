using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text LifeText;

    void Start()
    {
        BombPref.bombCount = 0;
        BombPref.life = 3;
    }

    void Update()
    {
        if(BombPref.bombCount == 3)
        {
            Debug.Log("Game Finish.");
            SceneManager.LoadScene(1);
        }

        LifeText.text = "Life: " + BombPref.life;
    }
}
