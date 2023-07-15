using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //doing public makes it accessible in unity
    public float speed = 5.5f;
    float inputX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       /// 0 is neither left is -1 right is 1 
           inputX = Input.GetAxisRaw("Horizontal");
           transform.Rotate(Vector3.forward * inputX * speed * Time.deltaTime);

    }
}
