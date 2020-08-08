using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 0.0f;
    public AudioClip niveles = null;
    public AudioClip instrucciones = null;
    public AudioClip modoprueba = null;
    public AudioClip proposito = null;
    public AudioClip salir = null;
    bool reproducirniveles = true;
    bool reproducirInstrucciones = true;
    bool reproducirModoPrueba = true;
    bool reproducirProposito = true;
    bool reproducirSalir = true;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        


        timer += Time.deltaTime;

        if (reproducirniveles)
            AudioSource.PlayClipAtPoint(niveles, new Vector3(0, 0, 0), 1);
        reproducirniveles = false;



        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Niveles");
           

        }

        if (Input.GetKeyDown("z"))
        {
            SceneManager.LoadScene("Instrucciones");
        }

        if (Input.GetKeyDown("x"))
        {
            SceneManager.LoadScene("ModoPrueba");
        }

        if (Input.GetKeyDown("c"))
        {
            SceneManager.LoadScene("Proposito");
        }
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }



        if (timer > 20)
        {
            timer = 0;
            reproducirniveles = true;
        }
            

       // GameObject.Find("Tiempo").GetComponent<Text>().text = "Tiempo: " + timer;



    }

   public void iniciar()
    {
        SceneManager.LoadScene("Niveles");
    }


    public void clickinstrucciones()
    {
        SceneManager.LoadScene("Instrucciones");
    }


    public void clickPrueba()
    {
        SceneManager.LoadScene("ModoPrueba");
    }

    public void clickProposito()
    {
        SceneManager.LoadScene("Proposito");
    }

   public void clickSalir()
    {
        Debug.Log("Click en salir");
        Application.Quit();
        Debug.Log("No se debe de ver");
    }

}


