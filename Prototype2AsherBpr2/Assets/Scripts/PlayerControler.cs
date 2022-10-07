using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float hoizontalInput;
    public float speed = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -15){
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        }
        hoizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hoizontalInput * Time.deltaTime * speed);
    }
}
