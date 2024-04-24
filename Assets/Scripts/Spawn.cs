using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float FrequencyLow = 2f;
    public float FrequencyHigh = 5f;
    public GameObject Obstacle;
    float TimeStamp;
    // Start is called before the first frame update
    void Start()
    {
        TimeStamp = Time.time + Random.Range(FrequencyLow, FrequencyHigh);       
    }
    private void Update()
    {
        if (Time.time >= TimeStamp)
        {
            TimeStamp = Time.time + Random.Range(FrequencyLow, FrequencyHigh);
            SpawnNew();
        }
    }
    void SpawnNew()
    {
        
        Instantiate(Obstacle, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);

    }
}
