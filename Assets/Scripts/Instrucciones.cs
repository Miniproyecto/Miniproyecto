using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instrucciones : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (Input.GetKeyDown("backspace"))
        {
            SceneManager.LoadScene("Menu");
        }



    }
}
