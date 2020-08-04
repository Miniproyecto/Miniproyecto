using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Perdio : MonoBehaviour
{

    public AudioClip perdiste = null;
    float timer;
    bool termino;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        termino = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (Input.GetKeyDown("backspace"))
        {
            SceneManager.LoadScene("Menu");
        }


        if(timer >= 0 && termino)
        {
            AudioSource.PlayClipAtPoint(perdiste, new Vector3(0, 0, 0), 1);
            termino = false;
        }

        if(timer >= 7)
        {
            timer = 0;
            termino = true;
        }

    }

    public void clickRegresar()
    {
        SceneManager.LoadScene("Menu");
    }
}
