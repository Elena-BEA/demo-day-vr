using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawning : MonoBehaviour
{
    public GameObject fruit;
    public GameObject[] spawnPoints;
    public int amount = 3;
    private int whereToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        whereToSpawn = 0;
        for(int i = 0; i <= amount; i++)
        {
            Instantiate(fruit,spawnPoints[whereToSpawn].transform.position,Quaternion.identity);
            whereToSpawn++;
            if(whereToSpawn==4)
            {
                whereToSpawn=0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
