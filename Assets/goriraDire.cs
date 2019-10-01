using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goriraDire : MonoBehaviour
{
    public GameObject goriraPre;
    float span;
    float delta;
    // Start is called before the first frame update
    void Start()
    {
        span = 3.0f;
        delta = 0;
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            GameObject go = Instantiate(goriraPre) as GameObject;
            go.name = goriraPre.name;
            go.transform.position = new Vector3(-7.0f, -1.0f, 0);
            delta =0;
        }
    }
}
