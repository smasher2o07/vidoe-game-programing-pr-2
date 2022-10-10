using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float hoizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }    

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        hoizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hoizontalInput * Time.deltaTime * speed);
    }
}
