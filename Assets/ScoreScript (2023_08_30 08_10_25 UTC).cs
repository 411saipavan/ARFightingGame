﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        score.text = "Your Score : " + PlayerPrefs.GetInt("Score");
    }
}
