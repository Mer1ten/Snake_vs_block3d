using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTail : MonoBehaviour
{
    public GameObject bone;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (bone.transform.localScale == new Vector3(0,0,0))
        {
            Destroy(bone);
        }
    }
}
