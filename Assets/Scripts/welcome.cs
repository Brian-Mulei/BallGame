﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class welcome : MonoBehaviour
{
    // Start is called before the first frame update
    public void Startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   
}
