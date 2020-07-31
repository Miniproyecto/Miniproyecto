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
        if (Input.GetKeyDown("space"))
        {
            if (timer < 10)
            {
                SceneManager.LoadScene("Niveles");
            }

            if (timer > 10 && timer < 20)
            {
                SceneManager.LoadScene("Instrucciones");
            }

            if (timer > 20 && timer < 30)
            {
                SceneManager.LoadScene("ModoPrueba");
            }

            if (timer > 30 && timer < 40)
            {
                SceneManager.LoadScene("Proposito");
            }



        }

        if(timer< 10)
        {
            GameObject.Find("Accion").GetComponent<Text>().text = "Accion: Seleccionar Niveles";
            if(reproducirniveles)
                AudioSource.PlayClipAtPoint(niveles, new Vector3(0, 0, 0), 1);
            reproducirniveles = false;


        }
        if (timer > 10 && timer < 20)
        {
            GameObject.Find("Accion").GetComponent<Text>().text = "Accion: Instrucciones";
            if(reproducirInstrucciones)
                AudioSource.PlayClipAtPoint(instrucciones, new Vector3(0, 0, 0), 1);
            reproducirInstrucciones = false;

        }
        if (timer > 20 && timer < 30)
        {
            GameObject.Find("Accion").GetComponent<Text>().text = "Accion: Modo prueba";
            if (reproducirModoPrueba)
                AudioSource.PlayClipAtPoint(modoprueba, new Vector3(0, 0, 0), 1);
            reproducirModoPrueba = false;
        }

        if (timer > 30 && timer < 40)
        {
            GameObject.Find("Accion").GetComponent<Text>().text = "Accion: Proposito";
            if (reproducirProposito)
                AudioSource.PlayClipAtPoint(proposito, new Vector3(0, 0, 0), 1);
            reproducirProposito = false;

        }

        if (timer > 40 && timer < 50)
        {
            GameObject.Find("Accion").GetComponent<Text>().text = "Accion: Salir";
            if (reproducirSalir)
                AudioSource.PlayClipAtPoint(salir, new Vector3(0, 0, 0), 1);
            reproducirSalir = false;

        }


        if (timer > 50)
        {
            timer = 0;
            reproducirniveles = true;
        }
            

        GameObject.Find("Tiempo").GetComponent<Text>().text = "Tiempo: " + timer;



    }
}
