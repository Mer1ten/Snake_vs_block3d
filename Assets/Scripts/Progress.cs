using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    public Walk PL;
    public Slider slider;
    public int CurScore;
    public int BestScore;
    public Text CurScoreText;
    public Text BestScoreText;
    private void Update()
    {
        float t = PL.transform.position.z;
        slider.value = t;
        if (CurScore > BestScore)
        {
            BestScore = CurScore;
        }
        CurScoreText.text = "CurrentScore: " + CurScore.ToString();
        BestScoreText.text = "Best:" + BestScore.ToString();
    }

}
