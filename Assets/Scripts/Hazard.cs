using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
    float speed = 4f;
    public float minSpeed = 4f;
    public float maxSpeed = 10f;
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        target = GameObject.FindGameObjectWithTag("PlanetCenter").transform;

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position =  Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Planet")
        {
            Destroy(gameObject);
        }
        if (other.tag == "PlayerCharacter")
        {
            SceneManager.LoadScene("Game");
        }
    }
}
