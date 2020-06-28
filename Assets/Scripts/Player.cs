using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed;
    Vector3 movement;
    float targetFPS = 60; // Temporary variable
    public GameObject bullet;
    int offsetY = 20;
    

    void Start()
    {
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        movement = new Vector3(h, v, 0) * movementSpeed * targetFPS;
        transform.position += movement * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + offsetY, 0), Quaternion.identity);
        }

    }
}
