using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerChange : MonoBehaviour
{
    // Update is called once per frame
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if(gameObject.GetComponent<Renderer>().material.GetColor("_Color") == Color.green)
            {
                gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
            }
            else if(gameObject.GetComponent<Renderer>().material.GetColor("_Color") == Color.blue)
            {
                gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            }
            else
            {
                gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            }
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if(gameObject.GetComponent<Renderer>().material.GetColor("_Color") == Color.green)
            {
                gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            }
            else if(gameObject.GetComponent<Renderer>().material.GetColor("_Color") == Color.blue)
            {
                gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            }
            else
            {
                gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
            }
        }
    }
}
