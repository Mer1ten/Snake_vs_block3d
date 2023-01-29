using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] BlockPrefabs;
    public GameObject[] FoodPrefabs;
    
    private void Awake()
    {
        
        for (int i = 0; i < 23; i++)
        {
            float k = Random.Range(0, 6);
            if (k > 1)
            {
                int prefabIndex = Random.Range(0, FoodPrefabs.Length);
                GameObject platform = Instantiate(FoodPrefabs[prefabIndex], transform);
                platform.transform.localPosition = CalculatFoodPos(i + 1);
            }
        }
        int blockCount = 23;
        for (int i = 0; i < blockCount; i++)
        {
            int prefabIndex = Random.Range(0, BlockPrefabs.Length);
            GameObject platform = Instantiate(BlockPrefabs[prefabIndex], transform);
            platform.transform.localPosition = CalculatBlockePos(i+2);
        }
    }
    private Vector3 CalculatBlockePos(int BlockIndex)
    {
        return new Vector3(0, 1, 10 * BlockIndex);
    }
    private Vector3 CalculatFoodPos(int FoodIndex)
    {
        float k =Random.Range(-3,3);
        return new Vector3(k, 1, 10 * FoodIndex + Random.Range(2,8));
    }

}
