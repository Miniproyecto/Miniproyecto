using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Proposito : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("backspace"))
        {
            SceneManager.LoadScene("Menu");
        }

    }


    public void clickRegresar()
    {
        SceneManager.LoadScene("Menu");
    }
}
