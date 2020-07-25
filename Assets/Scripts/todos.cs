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

       /* if (!terminofase1 && mostrar)
        {
            coroutine3 = esperar2(lista);
            StartCoroutine(coroutine3);
        }*/
            
        if( timer>=4 && terminofase2)
        {
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


    IEnumerator incio()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("inicio");
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
       
        
        terminofase1 = false;
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

                /* coroutine4 = esperar2(lista);
                 StartCoroutine(coroutine4);
                 invisible = true;
                 lista.Add(25);*/


            }

            if (random == 2  )
              {
            coroutine4 = esperar3(5);
            StartCoroutine(coroutine4);
            lista.Add(5);
            /* if (timer >= 1 && !gano)
             {
                 GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
                 timer = 0;
                 gano = true;
             }
             if (timer >= 1 && gano)
             {
                 GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = true;
                 timer = 0;
                 gano = false;
                 terminofase2 = true;
                 terminofase1 = false;
                 mostrar = true;
             }*/
            /*yield return new WaitForSeconds(2);

            GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(2);
            GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = true;
         yield return new WaitForSeconds(2);*/
            /* coroutine4 = esperar2(lista);
             StartCoroutine(coroutine4);
             invisible = true;
             lista.Add(5);*/

        }

            if (random == 3   )
             {
            coroutine4 = esperar3(50);
            StartCoroutine(coroutine4);
            lista.Add(50);
            /* yield return new WaitForSeconds(2);

             GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
             yield return new WaitForSeconds(2);
             GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = true;
           yield return new WaitForSeconds(2);*/
            /* coroutine4 = esperar2(lista);
             StartCoroutine(coroutine4);
             invisible = true;
             lista.Add(50);*/

        }

            if (random == 4  )
             {
            coroutine4 = esperar3(99);
            StartCoroutine(coroutine4);
            lista.Add(99);
            /*yield return new WaitForSeconds(2);

            GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(2);
            GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = true;
           yield return new WaitForSeconds(2);*/
            /* coroutine4 = esperar2(lista);
             StartCoroutine(coroutine4);
             invisible = true;
             lista.Add(99); */

        }

        Debug.Log(random);





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
                nivel++;
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = true;
                invisible = false;
                lista_jugador.Add(25);
                gano = true;
                Debug.Log("z");
            timer = 0;
            }

            if (Input.GetKey("x"))
            {
                nivel++;
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = true;
                invisible = false;
                lista_jugador.Add(5);
                gano = true;
                Debug.Log("x");

            }

            if (Input.GetKey("a"))
            {
                nivel++;
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = true;
                invisible = false;
                lista_jugador.Add(50);
                gano = true;
                Debug.Log("a");
                timer = 0;

            }

            if (Input.GetKey("s"))
            {
                nivel++;
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = true;
                invisible = false;
                lista_jugador.Add(99);
                Debug.Log("s");
                gano = true;
               
                timer = 0;

            }
            /* if(!lista.Equals(lista_jugador))
             {
                 perdio = true;
             }*/
        }//fin del for

       // terminofase2 = false;


        if (nivel > 1)
        {
            coroutine3 = esperar2(lista);
            StartCoroutine(coroutine3);
            terminofase2 = false;
            timer = 0;
        }
       
    }

   


    }
