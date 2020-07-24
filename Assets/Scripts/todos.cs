using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class todos : MonoBehaviour
{
    bool invisible = false;
    bool gano = true;
    int random = -1;
    int nivel = 1;
    float timer = 0;
    private IEnumerator coroutine;
    List<int> lista = new List<int>(); //lista donde esta la secuencia que se tiene que hacer
    List<int> lista_jugador = new List<int>(); //lista donde se pone lo que hizo el jugador
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fase1(nivel);


        if (Input.GetKey("z"))
        {
            GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = true;
            invisible = false;
        }

        if (Input.GetKey("x"))
        {
            GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = true;
            invisible = false;
        }

        if (Input.GetKey("a"))
        {
            GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = true;
            invisible = false;
        }

        if (Input.GetKey("s"))
        {
            GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = true;
            invisible = false;
        }

        if (Input.GetKeyDown("space"))
        {
            
           // GameObject.Find("Text").SetActive(false);
            gano = false;
            GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = true;

        
    }
        if (!gano)
        {
            coroutine = esperar2(lista);
            StartCoroutine(coroutine);
            gano = true;
        }


        timer = 0;
    }


    IEnumerator esperar2(List<int> lis)
    {
       foreach(var i in lis)
        {
            yield return new WaitForSecondsRealtime(1);
            if (i == 25)
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
            if (i == 5)
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
            if (i == 50)
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
            if (i == 99)
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSecondsRealtime(1);
            hola2(i);
        }
    }



    void hola2(int i)
    {
        if (i == 25)
        {
            GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = true;

        }
        if (i == 5)
        {
            GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = true;

        }
        if (i == 50)
        {
            GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = true;

        }
        if (i == 99)
        {
            GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = true;

        }
    }


    void fase1(int nivel)
    {
        for(int i=0; i<nivel; i++)
        {
            random = UnityEngine.Random.Range(0, 100);

            if (random == 25 && !invisible && gano)
            {

                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
                invisible = true;
                lista.Add(random);


            }

            if (random == 5 && !invisible && gano)
            {

                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
                invisible = true;
                lista.Add(random);

            }

            if (random == 50 && !invisible && gano)
            {

                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
                invisible = true;
                lista.Add(random);

            }

            if (random == 99 && !invisible && gano)
            {

                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
                invisible = true;
                lista.Add(random);

            }
        }//fin del for
        
    }


    }
