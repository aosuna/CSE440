using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUpdated : MonoBehaviour {

    public static int score;
    private Text ScoreText;

    // Use this for initialization
    void Awake()
    {

        ScoreText = GetComponent<Text>();
        score = 0;

    }
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + score;
    }

}
