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
    bool mostrar;
    float timer = 0.0f;
    private IEnumerator coroutine;
    private IEnumerator coroutine2;
    private IEnumerator coroutine3;

    private IEnumerator coroutine4;
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
        mostrar = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer+= Time.deltaTime;
        if (perdio)
        {
            // GameObject.Find("perdiste").SetActive(true);
            Debug.Log("Perdio");
        }

        if ( timer >=4 && terminofase1)
        {
            //fase1(nivel);
            terminofase1 = false;
            coroutine = fase1(nivel);
            StartCoroutine(coroutine);
            timer = 0;
            terminofase2 = true;
            Debug.Log("Listaaaa");
            foreach(var item in lista)
            {
                Debug.Log(item);
            }
            

        }
            
        if( timer>=4 && terminofase2)
        {
            coroutine2 = fase2(nivel);
            StartCoroutine(coroutine2);
            
            
        }

        
  

       


    }



    IEnumerator esperar2(List<int> lis)
    {
        Debug.Log("Esperar2");
       foreach(int i in lista)
        {
            yield return new WaitForSeconds(1);
            if (i == 25)
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
            if (i == 5)
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
            if (i == 50)
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
            if (i == 99)
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(1);
            hola2(i);
        }
        mostrar = false;
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
       
        
        
        mostrar = true;
    }


    IEnumerator fase1(int nivel)
    {
        Debug.Log("Fase1");
        random = UnityEngine.Random.Range(1, 5);
        yield return new WaitForSeconds(2);
      

            

            if (random == 1   )
            {
                coroutine4 = esperar3(25);
            StartCoroutine(coroutine4);
            lista.Add(25);


            }

            if (random == 2  )
              {
            coroutine4 = esperar3(5);
            StartCoroutine(coroutine4);
            lista.Add(5);

        }

            if (random == 3   )
             {
            coroutine4 = esperar3(50);
            StartCoroutine(coroutine4);
            lista.Add(50);


        }

            if (random == 4  )
             {
            coroutine4 = esperar3(99);
            StartCoroutine(coroutine4);
            lista.Add(99);


        }

        Debug.Log(random);





    }

    IEnumerator fase2(int nivel)
    {
        gano = false;
        Debug.Log("Fase2");
        //  yield return new WaitForSecondsRealtime(1);

        for (int i=0; i<nivel; i++)
        {
            

            if (Input.GetKeyDown("z"))
            {
                nivel++;
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = true;
                invisible = false;
                lista_jugador.Add(25);
                gano = true;
                Debug.Log("z");
                if (lista.Count == lista_jugador.Count)
                    timer = 0;
                else
                    timer = 1;
            }

            if (Input.GetKeyDown("x"))
            {
                nivel++;
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = true;
                invisible = false;
                lista_jugador.Add(5);
                gano = true;
                Debug.Log("x");
                if (lista.Count == lista_jugador.Count)
                    timer = 0;
                else
                    timer = 1;

            }

            if (Input.GetKeyDown("a"))
            {
                nivel++;
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = true;
                invisible = false;
                lista_jugador.Add(50);
                gano = true;
                Debug.Log("a");
                if (lista.Count == lista_jugador.Count)
                    timer = 0;
                else
                    timer = 1;

            }

            if (Input.GetKeyDown("s"))
            {
                nivel++;
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = true;
                invisible = false;
                lista_jugador.Add(99);
                Debug.Log("s");
                gano = true;

                if (lista.Count == lista_jugador.Count)
                    timer = 0;
                else
                    timer = 1;

            }
            /* if(!lista.Equals(lista_jugador))
             {
                 perdio = true;
             }*/
        }//fin del for

        // terminofase2 = false;


        if (lista_jugador.Count == lista.Count)
        {
            lista_jugador.Clear();
           // coroutine3 = esperar2(lista);
            //StartCoroutine(coroutine3);
            foreach(var i in lista)
            {
                /*coroutine3 = esperar3(item);
                StartCoroutine(coroutine3);*/
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
            terminofase2 = false;
            terminofase1 = true;
            timer = 0;
        }
       
    }

   


    }
