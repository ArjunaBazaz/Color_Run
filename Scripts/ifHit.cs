using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifHit : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(transform.position.y > -9)
        {
            if(collision.gameObject.GetComponent<Renderer>().material.GetColor("_Color").Equals(gameObject.GetComponent<Renderer>().material.GetColor("_Color")))
            {
                //logic.incrementHealth();
                logic.incrementScore();
            }
            else
            {
                logic.decrementHealth();
            }
        }
        else
        {
            logic.decrementHealth();
        }
        Destroy(gameObject);
    }
}
