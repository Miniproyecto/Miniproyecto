using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Niveles : MonoBehaviour
{
    // Start is called before the first frame update
    float timer= 0.0f;
    public AudioClip facil = null;
    bool reproducirfacil = true;
    public AudioClip medio = null;
    bool reproducirmedio = true;
    public AudioClip dificil = null;
    bool reproducirdificil = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (reproducirfacil)
            AudioSource.PlayClipAtPoint(facil, new Vector3(0, 0, 0), 1);
        reproducirfacil = false;

        if (Input.GetKeyDown("z"))
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (Input.GetKeyDown("x"))
        {
            SceneManager.LoadScene("nivel2");
        }

        if (Input.GetKeyDown("c"))
        {
            SceneManager.LoadScene("nivel3");
        }



        if (Input.GetKeyDown("backspace"))
        {
            SceneManager.LoadScene("Menu");
        }

        

        if (timer > 17)
        {
            timer = 0;

            reproducirfacil = true;
        }





    }


    public void clickNivel1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void clickNivel2()
    {
        SceneManager.LoadScene("nivel2");
    }

    public void clickNivel3()
    {
        SceneManager.LoadScene("nivel3");
    }


    public void clickRegresar()
    {
        SceneManager.LoadScene("Menu");
    }
}
