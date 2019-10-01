using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kabenekoCon : MonoBehaviour
{
    float span;
    public static bool kabenekokougeki=false;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.01f, 0, 0);
    
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "goriraPre")
        {
            transform.Translate(0.01f, 0, 0);
        }
    }
  
    


}
