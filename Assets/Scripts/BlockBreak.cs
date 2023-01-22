using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBreak : MonoBehaviour
{
    public int ScoreBreak;
    public bool Status;
    public TextMesh ScoreT;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreT.text = ScoreBreak.ToString();
        if (ScoreBreak <= 0)
            Destroy(gameObject);
    }
}
