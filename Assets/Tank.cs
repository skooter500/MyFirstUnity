using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 5f;
    public float rotSpeed = 180f;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * moveVertical * speed * Time.deltaTime);
        transform.Rotate(0, moveHorizontal * rotSpeed * Time.deltaTime, 0);
    }
}
