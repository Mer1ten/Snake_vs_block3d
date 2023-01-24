using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBreak : MonoBehaviour
{
    public int ScoreBreak;
    public bool Status;
    public TextMesh ScoreT;
    public Material mat;
    public float ColorChange;
    public GameObject gt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ColorChange = ScoreBreak / 50f;

        gt.GetComponent<Renderer>().material.SetFloat("_Color", ColorChange);
        ScoreT.text = ScoreBreak.ToString();
        if (ScoreBreak <= 0)
            Destroy(gameObject);
    }
}
