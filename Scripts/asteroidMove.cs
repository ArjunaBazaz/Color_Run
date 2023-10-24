using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidMove : MonoBehaviour
{
    public float moveSpeed = 0.1F;
    private Vector3 moveDown;
    private float deadZone = -15.0F;
    private float x;
    public float rotationSpeed = 180.0F;
    // Update is called once per frame
    void Start()
    {
        x = Random.Range(0, 3);
        if(x < 1)
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
        else if(x < 2)
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
        }
    }

    void Update()
    {
        moveDown.y = moveSpeed * Time.deltaTime;
        transform.position -= moveDown;
        transform.Rotate(0.0F, 0.0F, rotationSpeed * Time.deltaTime);
        if(transform.position.y < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
