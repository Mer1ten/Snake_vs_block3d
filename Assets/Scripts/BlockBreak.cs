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
    public GameLogic GL;
    public int k;
    public bool test;
    public AudioSource audioSource;
    public ParticleSystem part; 
    void Start()
    {
        
    }
    private void Awake()
    {
        k = GL.LevelIndex;
        ScoreBreak = Random.Range(1, 9);
        ScoreBreak += k * Random.Range(0, 3);
        
    }
    // Update is called once per frame
    void Update()
    {
        ColorChange = ScoreBreak / 50f;
        
        gt.GetComponent<Renderer>().material.SetFloat("_Color", ColorChange);
        if (test)
        ScoreT.text = (ScoreBreak).ToString();
        if (ScoreBreak <= 0 && test)
        {
            part.Play();
            audioSource.Play();
            test = false;
            ScoreT.text = "";
            gt.transform.localPosition -= new Vector3(0, 2, 0);
        }
    }
}
