using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kabenekoCon : MonoBehaviour
{
    public bool a = false;
    float span;
    public static bool kabenekokougeki=false;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(a==false)
        GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0);
        if(a==true)
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        
        if (collision.gameObject.name == "goriraPre")
        {
            Debug.Log("drfuijkotygijo");
            a = true;

        }
        
    }
  
    


}
