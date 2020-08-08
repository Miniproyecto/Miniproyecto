﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class todos : MonoBehaviour
{
    
    int random ;
    int nivel;
    int contador;
    bool terminofase1;
    bool terminofase2 ;
    bool primera_vez = true;
    bool turno = true;
    float timer = 0.0f;
    private IEnumerator coroutine;
    private IEnumerator coroutine2;

    public AudioClip sonido_z = null;
    public AudioClip sonido_x = null;
    public AudioClip sonido_a = null;
    public AudioClip sonido_s = null;
    public AudioClip z = null;
    public AudioClip x = null;
    public AudioClip a = null;
    public AudioClip s = null;
    public AudioClip escucha = null;
    public AudioClip tu_turno = null;


    private IEnumerator coroutine4;
    List<int> lista = new List<int>(); //lista donde esta la secuencia que se tiene que hacer
    List<int> lista_jugador = new List<int>(); //lista donde se pone lo que hizo el jugador

    /*bool active;
    Canvas canvas;*/

    // Start is called before the first frame update
    void Start()
    {
       // GameObject.Find("perdiste").SetActive(false);
        terminofase1 = true;
        terminofase2 = false;
        nivel = 1;
        contador = 0;
        //GameObject.Find("Canvas").active = false;

    }

    // Update is called once per frame
    void Update()
    {
        timer+= Time.deltaTime;
    

        if ( timer >=4 && terminofase1)
        {
            //fase1(nivel);
            contador = 0;
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

       /* if (Input.GetKeyDown("space"))
        {
            active = !active;
            canvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1; // si active es 1 se pausa si es 0 se quita la pausa
        }

        if (Input.GetKeyDown("backspace") && !active)
        {
            SceneManager.LoadScene("Menu");
        }*/


    }



    IEnumerator esperar2(List<int> lis)
    {
       // Debug.Log("Esperar2");
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
    }


    IEnumerator esperar3(int i)
    {
       // Debug.Log("Esperar3");
        
            yield return new WaitForSecondsRealtime(1);
            if (i == 25)
        {
             GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(z, new Vector3(0, 0, 0), 1);
            AudioSource.PlayClipAtPoint(sonido_z, new Vector3(0, 0, 0), 1);
            


        }
            if (i == 5)
        {
            GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(x, new Vector3(0, 0, 0), 1);
            AudioSource.PlayClipAtPoint(sonido_x, new Vector3(0, 0, 0), 1);
            

        }
        if (i == 50)
        {
            GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(a, new Vector3(0, 0, 0), 1);
            AudioSource.PlayClipAtPoint(sonido_a, new Vector3(0, 0, 0), 1);
           

        }
        if (i == 99)
        {
            GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(s, new Vector3(0, 0, 0), 1);
            AudioSource.PlayClipAtPoint(sonido_s, new Vector3(0, 0, 0), 1);
            

        }
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
        turno = true;
       // Debug.Log("Fase1");
        random = UnityEngine.Random.Range(1, 5);
        if (primera_vez)
        {
            AudioSource.PlayClipAtPoint(escucha, new Vector3(0, 0, 0), 1);

            yield return new WaitForSeconds(1);
            primera_vez = false;
        }

        yield return new WaitForSeconds(0);
      

            

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

       // Debug.Log(random);





    }

    IEnumerator fase2(int nivel)
    {
        // Debug.Log("Fase2");
        //  yield return new WaitForSecondsRealtime(1);

       


        if (lista_jugador.Count == lista.Count)
        {

            if (!lista.SequenceEqual(lista_jugador))
            {
                GameObject.Find("perdiste").SetActive(false);
                Debug.Log("perdiste");
                
            }

            lista_jugador.Clear();

            AudioSource.PlayClipAtPoint(escucha, new Vector3(0, 0, 0), 1);

            yield return new WaitForSeconds(1);

            foreach (var i in lista)
            {

                yield return new WaitForSecondsRealtime(1);
                if (i == 25)
                {
                    GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(z, new Vector3(0, 0, 0), 1);
                    AudioSource.PlayClipAtPoint(sonido_z, new Vector3(0, 0, 0), 1);
                    

                }
                if (i == 5)
                {
                    GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(x, new Vector3(0, 0, 0), 1);
                    AudioSource.PlayClipAtPoint(sonido_x, new Vector3(0, 0, 0), 1);
                    

                }
                if (i == 50)
                {
                    GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(a, new Vector3(0, 0, 0), 1);
                    AudioSource.PlayClipAtPoint(sonido_a, new Vector3(0, 0, 0), 1);
                   

                }
                if (i == 99)
                {
                    GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(s, new Vector3(0, 0, 0), 1);
                    AudioSource.PlayClipAtPoint(sonido_s, new Vector3(0, 0, 0), 1);
                    

                }
                yield return new WaitForSecondsRealtime(1);
                hola2(i);
            }

            

            terminofase2 = false;
            terminofase1 = true;
            timer = 0;
        }

        if (turno)
        {
            turno = false;
            AudioSource.PlayClipAtPoint(tu_turno, new Vector3(0, 0, 0), 1);

            yield return new WaitForSeconds(1);
           
        }
        

        for (int i=0; i<nivel; i++)
        {


            if (Input.GetKeyDown("z"))
            {
                nivel++;
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = true;
                

                lista_jugador.Add(25);
                // Debug.Log("z");
                AudioSource.PlayClipAtPoint(z, new Vector3(0, 0, 0), 1);
                AudioSource.PlayClipAtPoint(sonido_z, new Vector3(0, 0, 0), 1);
                

                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;
                if (!(lista.ElementAt(contador) == 25))
                {
                    Debug.Log("Maaaaaaal");
                    SceneManager.LoadScene("Perdio");

                }
                contador++;

            }

            if (Input.GetKeyDown("x"))
            {
                
                nivel++;
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = true;
                lista_jugador.Add(5);
                //Debug.Log("x")
                AudioSource.PlayClipAtPoint(x, new Vector3(0, 0, 0), 1);
                AudioSource.PlayClipAtPoint(sonido_x, new Vector3(0, 0, 0), 1);
                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;
                if (!(lista.ElementAt(contador) == 5))
                {
                    Debug.Log("Maaaaaaal");
                    SceneManager.LoadScene("Perdio");

                }
                contador++;

            }

            if (Input.GetKeyDown("a"))
            {
                nivel++;
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = true;
                lista_jugador.Add(50);
                // Debug.Log("a");
                AudioSource.PlayClipAtPoint(a, new Vector3(0, 0, 0), 1);
                AudioSource.PlayClipAtPoint(sonido_a, new Vector3(0, 0, 0), 1);
                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;
                if (!(lista.ElementAt(contador) == 50))
                {
                    Debug.Log("Maaaaaaal");
                    SceneManager.LoadScene("Perdio");

                }
                contador++;


            }

            if (Input.GetKeyDown("s"))
            {
                nivel++;
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = true;
                lista_jugador.Add(99);
                // Debug.Log("s");
                AudioSource.PlayClipAtPoint(s, new Vector3(0, 0, 0), 1);
                AudioSource.PlayClipAtPoint(sonido_s, new Vector3(0, 0, 0), 1);
                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;
                if (!(lista.ElementAt(contador) == 99))
                {
                    Debug.Log("Maaaaaaal");
                    SceneManager.LoadScene("Perdio");

                }
                contador++;


            }

        }//fin del for



        
       
    }

   


    }
