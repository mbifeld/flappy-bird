using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class currentscore : MonoBehaviour
{
    public TextMeshProUGUI currentscorenum;
    public TextMeshProUGUI currenthighscorenum;

    // Update is called once per frame
    void Update()
    {
        currentscorenum.text = "" + GameManagement.score;

    }
    private void Start()
    {
        currenthighscorenum.text = PlayerPrefs.GetInt("highscore", 0).ToString();
    }
}
