using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class todos_lvl2 : MonoBehaviour
{
    // Start is called before the first frame update
    int random;
    int nivel;
    bool terminofase1;
    bool terminofase2;
    float timer = 0.0f;
    private IEnumerator coroutine;
    private IEnumerator coroutine2;

    public AudioClip sonido_z = null;
    public AudioClip sonido_x = null;
    public AudioClip sonido_a = null;
    public AudioClip sonido_s = null;
    public AudioClip sonido_d = null;

    private IEnumerator coroutine4;
    List<int> lista = new List<int>(); //lista donde esta la secuencia que se tiene que hacer
    List<int> lista_jugador = new List<int>(); //lista donde se pone lo que hizo el jugador

    // Start is called before the first frame update
    void Start()
    {
        // GameObject.Find("perdiste").SetActive(false);
        terminofase1 = true;
        terminofase2 = false;
        nivel = 1;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (timer >= 4 && terminofase1)
        {
            //fase1(nivel);
            terminofase1 = false;
            coroutine = fase1(nivel);
            StartCoroutine(coroutine);
            timer = 0;
            terminofase2 = true;
            Debug.Log("Listaaaa");
            foreach (var item in lista)
            {
                Debug.Log(item);
            }


        }

        if (timer >= 4 && terminofase2)
        {
            coroutine2 = fase2(nivel);
            StartCoroutine(coroutine2);


        }



    }



    IEnumerator esperar2(List<int> lis)
    {
        Debug.Log("Esperar2");
        foreach (int i in lista)
        {
            yield return new WaitForSeconds(1);
            if (i == 1)
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
            if (i == 2)
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
            if (i == 3)
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
            if (i == 4)
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
            if (i == 5)
                GameObject.Find("Personaje5").GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(1);
            hola2(i);
        }
    }


    IEnumerator esperar3(int i)
    {
        Debug.Log("Esperar3");

        yield return new WaitForSecondsRealtime(1);
        if (i == 1)
        {
            GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(sonido_z, new Vector3(0, 0, 0), 1);

        }
        if (i == 2)
        {
            GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(sonido_x, new Vector3(0, 0, 0), 1);

        }
        if (i == 3)
        {
            GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(sonido_a, new Vector3(0, 0, 0), 1);

        }
        if (i == 4)
        {
            GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(sonido_s, new Vector3(0, 0, 0), 1);

        }
        if (i == 5)
        {
            GameObject.Find("Personaje5").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(sonido_d, new Vector3(0, 0, 0), 1);

        }
        yield return new WaitForSecondsRealtime(1);
        hola2(i);

    }



    void hola2(int i)
    {
        if (i == 1)
        {
            GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = true;

        }
        if (i == 2)
        {
            GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = true;

        }
        if (i == 3)
        {
            GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = true;

        }
        if (i == 4)
        {
            GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = true;

        }
        if (i == 5)
        {
            GameObject.Find("Personaje5").GetComponent<SpriteRenderer>().enabled = true;

        }



    }


    IEnumerator fase1(int nivel)
    {
        Debug.Log("Fase1");
        random = UnityEngine.Random.Range(1, 6);
        yield return new WaitForSeconds(0);




        if (random == 1)
        {
            coroutine4 = esperar3(1);
            StartCoroutine(coroutine4);
            lista.Add(1);


        }

        if (random == 2)
        {
            coroutine4 = esperar3(2);
            StartCoroutine(coroutine4);
            lista.Add(2);

        }

        if (random == 3)
        {
            coroutine4 = esperar3(3);
            StartCoroutine(coroutine4);
            lista.Add(3);


        }

        if (random == 4)
        {
            coroutine4 = esperar3(4);
            StartCoroutine(coroutine4);
            lista.Add(4);


        }

        if (random == 5)
        {
            coroutine4 = esperar3(5);
            StartCoroutine(coroutine4);
            lista.Add(5);


        }

        Debug.Log(random);





    }

    IEnumerator fase2(int nivel)
    {
        Debug.Log("Fase2");
        //  yield return new WaitForSecondsRealtime(1);


        if (lista_jugador.Count == lista.Count)
        {

            if (!lista.SequenceEqual(lista_jugador))
            {
                GameObject.Find("perdiste").SetActive(false);
                Debug.Log("perdiste");

            }

            lista_jugador.Clear();

            foreach (var i in lista)
            {

                yield return new WaitForSecondsRealtime(1);
                if (i == 1)
                {
                    GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(sonido_z, new Vector3(0, 0, 0), 1);

                }
                if (i == 2)
                {
                    GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(sonido_x, new Vector3(0, 0, 0), 1);

                }
                if (i == 3)
                {
                    GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(sonido_a, new Vector3(0, 0, 0), 1);

                }
                if (i == 4)
                {
                    GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(sonido_s, new Vector3(0, 0, 0), 1);

                }
                if (i == 5)
                {
                    GameObject.Find("Personaje5").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(sonido_d, new Vector3(0, 0, 0), 1);

                }
                yield return new WaitForSecondsRealtime(1);
                hola2(i);
            }



            terminofase2 = false;
            terminofase1 = true;
            timer = 0;
        }



        for (int i = 0; i < nivel; i++)
        {


            if (Input.GetKeyDown("z"))
            {
                nivel++;
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = true;


                lista_jugador.Add(1);
                Debug.Log("z");
                AudioSource.PlayClipAtPoint(sonido_z, new Vector3(0, 0, 0), 1);

                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;
            }

            if (Input.GetKeyDown("x"))
            {
                nivel++;
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = true;
                lista_jugador.Add(2);
                Debug.Log("x");
                AudioSource.PlayClipAtPoint(sonido_x, new Vector3(0, 0, 0), 1);
                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;

            }

            if (Input.GetKeyDown("a"))
            {
                nivel++;
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = true;
                lista_jugador.Add(3);
                Debug.Log("a");
                AudioSource.PlayClipAtPoint(sonido_a, new Vector3(0, 0, 0), 1);
                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;

            }

            if (Input.GetKeyDown("s"))
            {
                nivel++;
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = true;
                lista_jugador.Add(4);
                Debug.Log("s");

                AudioSource.PlayClipAtPoint(sonido_s, new Vector3(0, 0, 0), 1);
                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;

            }

            if (Input.GetKeyDown("d"))
            {
                nivel++;
                GameObject.Find("Personaje5").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje5").GetComponent<SpriteRenderer>().enabled = true;
                lista_jugador.Add(5);
                Debug.Log("d");

                AudioSource.PlayClipAtPoint(sonido_d, new Vector3(0, 0, 0), 1);
                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;

            }

        }//fin del for





    }
}
