using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Proposito : MonoBehaviour

{
    public AudioClip proposito2 = null;
    bool reproducirproposito = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    if (reproducirproposito)
        AudioSource.PlayClipAtPoint(proposito2, new Vector3(0, 0, 0), 1);
    reproducirproposito = false;


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
