using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float FrequencyLow = 2f;
    public float FrequencyHigh = 5f;
    float freq;
    public GameObject Obstacle;
    float TimeStamp;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnNew", 0f, Random.Range(FrequencyLow, FrequencyHigh));
    }

    void SpawnNew()
    {
        
        Instantiate(Obstacle, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);

    }
}
