using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FoodScore : MonoBehaviour
{
    public int ScoreEat;
    public bool Status = true;
    public TextMesh ScoreT;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreT.text = ScoreEat.ToString();
        if (Status == false)
        {
            Destroy(gameObject);
        }
    }
}
