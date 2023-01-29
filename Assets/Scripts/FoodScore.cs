using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FoodScore : MonoBehaviour
{
    public int ScoreEat;
    public bool Status = true;
    public TextMesh ScoreT;
    public float ColorChange;
    public GameObject gt;
    public GameLogic GL;
    void Start()
    {
        
    }
    private void Awake()
    {
        ScoreEat = Random.Range(1, 10);
        ScoreEat += GL.LevelIndex * Random.Range(0, 2);
        ScoreEat -= GL.LevelIndex * Random.Range(0, 1);
    }
    // Update is called once per frame
    void Update()
    {
        ColorChange = ScoreEat / 40f;
        gt.GetComponent<Renderer>().material.SetFloat("_Color", ColorChange);
        ScoreT.text = (ScoreEat+1).ToString();
        if (Status == false)
        {
            Destroy(gameObject);
        }
    }
}
