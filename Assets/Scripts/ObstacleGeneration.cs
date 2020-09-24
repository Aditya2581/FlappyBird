using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGeneration : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private float yPos = 0f;

    public float maxTimeDiff = 1.5f;
    public float topHight;
    public float bottomHeight;
    public float spawnPoint;

    private float time = 0f;
    
    private void Update()
    {
        if (time >= maxTimeDiff)
        {
            yPos = Random.Range(bottomHeight, topHight);
            Instantiate(obstaclePrefab, new Vector3(spawnPoint, yPos), Quaternion.identity);
            time = 0f;
        }
        time += Time.deltaTime;
    }
}
