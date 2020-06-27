using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed;
    Vector3 movement;
    Vector3 worldLimit;
    float shipWidth;
    float shipHeight;

    void Start()
    {
        shipWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        shipHeight = transform.GetComponent<SpriteRenderer>().bounds.size.z / 2;
    }
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * movementSpeed;
        transform.position += movement * Time.deltaTime;

    }
}
