using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextUIController : MonoBehaviour
{
    Text scoreText = null;

    private void Start()
    {
        scoreText = GetComponent<Text>();
    }

    private void Update()
    {
        scoreText.text = $"Score : {GameManager.Score}";
    }
}
