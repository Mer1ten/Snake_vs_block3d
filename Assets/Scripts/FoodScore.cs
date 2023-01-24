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
    void Start()
    {
        
    }
    private void Awake()
    {
        ScoreEat = Random.Range(1, 10);
    }
    // Update is called once per frame
    void Update()
    {
        ColorChange = ScoreEat / 50f;
        gt.GetComponent<Renderer>().material.SetFloat("_Color", ColorChange);
        ScoreT.text = (ScoreEat+1).ToString();
        if (Status == false)
        {
            Destroy(gameObject);
        }
    }
}
