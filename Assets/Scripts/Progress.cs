using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class Progress : MonoBehaviour
{
    public Walk PL;
    public Slider slider;
    public int CurScore;
    public int BestScore;
    public Text CurScoreText;
    public Text BestScoreText;
    private void Start()
    {
        CurScore = PlayerPrefs.GetInt("ScoreCur");
        BestScore = PlayerPrefs.GetInt("BestScore");
    }
    private void Update()
    {
        float t = PL.transform.position.z;
        slider.value = t;
        if (CurScore > BestScore)
        {
            BestScore = CurScore;
            PlayerPrefs.SetInt("BestScore", BestScore);
            PlayerPrefs.Save();
        }

        CurScoreText.text = "CurrentScore: " + CurScore.ToString();
        BestScoreText.text = "Best:" + BestScore.ToString();
    }

}
