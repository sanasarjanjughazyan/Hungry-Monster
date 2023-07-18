using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50;

    private Rigidbody rb;
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        MoveCharacter(movement);
        KeepInBoundaries();
    }

    void MoveCharacter(Vector3 direction)
    {
        rb.AddForce(Vector3.forward * speed * direction.z * Time.fixedDeltaTime, ForceMode.Impulse);
        rb.AddForce(Vector3.right * speed * direction.x * Time.fixedDeltaTime, ForceMode.Impulse);
    }

    void KeepInBoundaries() {
        
    }
}
