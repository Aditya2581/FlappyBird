using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float destroyPoint;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; 
        if (transform.position.x <= destroyPoint)
        {
            Destroy(gameObject);
        }
    }
}
