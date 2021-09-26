using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPref : MonoBehaviour
{
    BombSpawner bombSpawner;

    public static int life = 3;
    public static int bombCount;

    // Start is called before the first frame update
    void Start()
    {
        bombSpawner = GameObject.FindObjectOfType<BombSpawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            life = life - 1;
            bombCount = bombCount + 1;
            Debug.Log("bomb count = " + bombCount);

            bombSpawner.SpawnBomb();
            bombSpawner.totalBombs.Remove(gameObject);
            Destroy(gameObject, 0.05f);
        }


    }
}
