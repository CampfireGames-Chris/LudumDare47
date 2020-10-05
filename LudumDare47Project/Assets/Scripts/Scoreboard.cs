using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public Text score;
    public int value;
    // Start is called before the first frame update
    void Start()
    {
        value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + value.ToString();
    }
}
