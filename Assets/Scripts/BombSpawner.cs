using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public List<GameObject> bombs = new List<GameObject>();

    public List<GameObject> totalBombs = new List<GameObject>();
    private float x, y, z;


    public void SpawnBomb()
    {
        if (totalBombs.Count < 3)
        {
            for (int i = 0; i < 3; i++)
            {
                x = Random.Range(-4.00f, 4.00f);
                z = Random.Range(-5.00f, 5.00f); 
                y = 0.6f;


                GameObject temp = Instantiate(bombs[i], new Vector3(x, y, z), Quaternion.identity);
                totalBombs.Add(temp);
            }

        }

    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            SpawnBomb();
        }


    }
}
