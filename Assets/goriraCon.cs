using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goriraCon : MonoBehaviour
{
    public bool b=false; 
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(b==false)
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0);
        if(b==true)
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }


    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "kabenekoPre")
        {
            Debug.Log("fdgfdddddddfv");
            b = true;
        }

    }
}
