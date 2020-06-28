
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    public GameObject battery1;
    public GameObject battery2;
    public GameObject battery3;
    public delegate void Die();
    public static event Die die;

    Vector3 movement;
    public float movementSpeed;
    float targetFPS = 60; // Temporary variable
    int offsetY = 20;
    int energy = 3;

    void Start()
    {
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        movement = new Vector3(h, v, 0) * movementSpeed * targetFPS;
        transform.position += movement * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + offsetY, 0), Quaternion.identity);
        }
        HealthCondition();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            energy--;
        }
        if (energy <= 0)
        {
            die();
        }
    }
    void HealthCondition()
    {
        if (energy == 3)
        {
            battery1.SetActive(true);
            battery2.SetActive(true);
            battery3.SetActive(true);
        }
        if (energy == 2)
        {
            battery1.SetActive(true);
            battery2.SetActive(true);
            battery3.SetActive(false);
        }
        if (energy == 1)
        {
            battery1.SetActive(true);
            battery2.SetActive(false);
            battery3.SetActive(false);
        }
    }
}
