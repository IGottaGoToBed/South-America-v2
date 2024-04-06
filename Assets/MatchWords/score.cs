using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public Text Score;
    private int score = 0;

    // Reference to the script containing the boolean value
    public DragAndDrop dragAndDropScript;

    void Start()
    {
        UpdateScoreboard();
    }

    void Update()
    {
        if (dragAndDropScript.correct)
        {
            AddPoint();
        }
    }

    void AddPoint()
    {
        score++;
        UpdateScoreboard();
    }

    void UpdateScoreboard()
    {
        Score.text = "Score: " + score.ToString();
    }
}
