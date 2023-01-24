using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandobBLockPos : MonoBehaviour
{
    public GameObject[] Blocks;
    bool[] usedpos = new bool[5]{false, false, false, false,false};
    public float[] Pos = new float[5] { -2.5f, -1.25f, 0, 1.25f, 2.5f };
    private void Awake()
    {
        for (int i = 0; i < Blocks.Length; i++)
        {
            int posindex = Random.Range(0, 5);
            if (usedpos[posindex] == true)
            {
                while (usedpos[posindex] == true)
                {
                    posindex = Random.Range(0, 5);
                }
            }

            usedpos[posindex] = true;
            
            Blocks[i].transform.localPosition = new Vector3(Pos[posindex], 0, 0);

        }
    }

}
