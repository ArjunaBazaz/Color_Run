using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private Vector3 direction;
    public float scaler = 0.1F;
    public bool living = true;

    // Update is called once per frame
    void Update()
    {
        direction.x = 0.000F;
        if((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && transform.position.x > -15.5)
        {
            direction.x -= scaler*Time.deltaTime;
        }
        else if((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && transform.position.x < 15.5)
        {
            direction.x += scaler*Time.deltaTime;
        }
        transform.position += direction;
    }
}
