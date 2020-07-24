using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripter : MonoBehaviour
{
    int x = 0;
    int y = 0;
    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100) == 5 )
        {
            if (!flag)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                flag = true;
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
                flag = false;
            }

        }

            

        
    }
}
