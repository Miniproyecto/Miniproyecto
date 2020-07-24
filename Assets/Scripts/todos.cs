using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class todos : MonoBehaviour
{
    
    int random = -1;
    int nivel;
    bool invisible = false;
    bool gano;
    bool terminofase1;
    bool terminofase2 ;
    bool perdio = false;
    private IEnumerator coroutine;
    private IEnumerator coroutine2;
    private IEnumerator coroutine3;
    List<int> lista = new List<int>(); //lista donde esta la secuencia que se tiene que hacer
    List<int> lista_jugador = new List<int>(); //lista donde se pone lo que hizo el jugador

    // Start is called before the first frame update
    void Start()
    {
       // GameObject.Find("perdiste").SetActive(false);
        terminofase1 = true;
        terminofase2 = false;
        gano = false;
        nivel = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (perdio)
        {
            // GameObject.Find("perdiste").SetActive(true);
            Debug.Log("Perdio");
        }

        if ( terminofase1)
        {
            coroutine = fase1(nivel);
            StartCoroutine(coroutine);

        }
            
        if( terminofase2)
        {
            StopCoroutine(coroutine);
            coroutine2 = fase2(nivel);
            StartCoroutine(coroutine2);
        }

        
  
        


       /* if (!gano)
        {
            coroutine = esperar2(lista);
            StartCoroutine(coroutine);
            gano = true;
        }*/

       


    }


    IEnumerator esperar2(List<int> lis)
    {
        Debug.Log("Esperar2");
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


    IEnumerator esperar3(int i)
    {
        Debug.Log("Esperar3");
        
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


    IEnumerator fase1(int nivel)
    {
        Debug.Log("Fase1");
        random = UnityEngine.Random.Range(0, 5);
        for (int i=0; i<nivel; i++)
        {

            if (invisible)
                break;


            if (random == 1   )
            {
                /* yield return new WaitForSecondsRealtime(1);

                 GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
                 yield return new WaitForSecondsRealtime(1);
                 GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = true; */
               
                 yield return new WaitForSecondsRealtime(1);
                coroutine3 = esperar3(random);
                StartCoroutine(coroutine3);
                invisible = true;
                lista.Add(25);


            }

            if (random == 2  )
            {
               /* yield return new WaitForSecondsRealtime(1);

                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = true;*/
                 yield return new WaitForSecondsRealtime(1);
                coroutine3 = esperar3(random);
                StartCoroutine(coroutine3);
                invisible = true;
                lista.Add(5);

            }

            if (random == 3   )
            {
               /* yield return new WaitForSecondsRealtime(1);

                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = true;*/
                 yield return new WaitForSecondsRealtime(1);
                coroutine3 = esperar3(random);
                StartCoroutine(coroutine3);
                invisible = true;
                lista.Add(50);

            }

            if (random == 4  )
            {
                /*yield return new WaitForSecondsRealtime(1);

                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = true;*/
                 yield return new WaitForSecondsRealtime(1);
                coroutine3 = esperar3(random);
                StartCoroutine(coroutine3);
                invisible = true;
                lista.Add(99);

            }
        }//fin del for
        terminofase2 = true;
        terminofase1 = false;

        
    }

    IEnumerator fase2(int nivel)
    {
        gano = false;
        Debug.Log("Fase2");
        //  yield return new WaitForSecondsRealtime(1);
        GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = true;
        for (int i=0; i<nivel; i++)
        {

            if (Input.GetKey("z"))
            {
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = true;
                invisible = false;
                lista_jugador.Add(25);
                gano = true;
                Debug.Log("z");
                nivel++;
            }

            if (Input.GetKey("x"))
            {
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = true;
                invisible = false;
                lista_jugador.Add(5);
                gano = true;
                Debug.Log("x");
                nivel++;

            }

            if (Input.GetKey("a"))
            {
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = true;
                invisible = false;
                lista_jugador.Add(50);
                gano = true;
                Debug.Log("a");
                nivel++;

            }

            if (Input.GetKey("s"))
            {
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = true;
                invisible = false;
                lista_jugador.Add(99);
                Debug.Log("s");
                gano = true;
                nivel++;

            }
            /* if(!lista.Equals(lista_jugador))
             {
                 perdio = true;
             }*/
        }//fin del for

        yield return new WaitForSecondsRealtime(2);
        terminofase2 = false ;

        if (nivel > 1)
        {
            coroutine3 = esperar2(lista);
            StartCoroutine(coroutine3);
        }
    }

   


    }
