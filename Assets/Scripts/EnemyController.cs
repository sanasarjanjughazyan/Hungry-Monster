using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 0.3f;

    private float zBoundary = 24;
    private float xBoundary = 24;
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        GenerateRandomDiraction();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
        // bug in the world, object need to be 0.5 higher
        transform.position = new Vector3(transform.position.x, 0.51f, transform.position.z);

        if (transform.position.x > xBoundary)
        {
            transform.position = new Vector3(xBoundary, transform.position.y, transform.position.z);
            GenerateRandomDiraction();
        }
        if (transform.position.x < -xBoundary)
        {
            transform.position = new Vector3(-xBoundary, transform.position.y, transform.position.z);
            GenerateRandomDiraction();
        }
        if (transform.position.z > zBoundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundary);
            GenerateRandomDiraction();
        }
        if (transform.position.z < -zBoundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBoundary);
            GenerateRandomDiraction();
        }
    }

    private void GenerateRandomDiraction()
    {
        moveDirection =  new Vector3(Random.Range(-xBoundary, xBoundary), 0, Random.Range(-zBoundary, zBoundary)).normalized;
    }
}
