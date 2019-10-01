using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goriraCon : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2D.position = Vector3.forward * 0.1f;
    }


    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "kabenekoPre")
        {
           
        }
       
    }
}
