using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] BlockPrefabs;
    public GameObject[] FoodPrefabs;
    public GameLogic gl;
    private void Awake()
    {
        int levelIndex = gl.LevelIndex;
        Random random = new Random(levelIndex);
        for (int i = 0; i < 23; i++)
        {
            float k = RandowmRange(random, 0, 6);
            if (k > 1)
            {
                int prefabIndex = RandowmRange(random, 0, FoodPrefabs.Length);
                GameObject platform = Instantiate(FoodPrefabs[prefabIndex], transform);
                platform.transform.localPosition = CalculatFoodPos(i + 1,i);
            }
        }
        int blockCount = 23;
        for (int i = 0; i < blockCount; i++)
        {
            int prefabIndex = RandowmRange(random, 0, BlockPrefabs.Length);
            GameObject platform = Instantiate(BlockPrefabs[prefabIndex], transform);
            platform.transform.localPosition = CalculatBlockePos(i+2);
        }
    }
    private Vector3 CalculatBlockePos(int BlockIndex)
    {
        return new Vector3(0, 1, 10 * BlockIndex);
    }
    private Vector3 CalculatFoodPos(int FoodIndex,int p)
    {
        int levelIndex = gl.LevelIndex;
        Random random = new Random(levelIndex + p );
        float k = RandowmRangef(random,-2.2f,2.2f);
        return new Vector3(k, 1, 10 * FoodIndex + RandowmRange(random, 2,8));
    }
    private int RandowmRange(Random random, int min, int maxExclusive)
    {
        int number = random.Next();
        int lenght = maxExclusive - min;
        number %= lenght;
        return min + number;
    }
    private float RandowmRangef(Random random, float min, float maxExclusive)
    {
        float number = random.Next();
        float lenght = maxExclusive - min;
        number %= lenght;
        return min + number;
    }

}
