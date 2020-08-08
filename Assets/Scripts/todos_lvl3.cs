using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class todos_lvl3 : MonoBehaviour
{
    // Start is called before the first frame update
    int random;
    int nivel;
    int contador;
    bool terminofase1;
    bool terminofase2;
    bool primera_vez = true;
    bool turno = true;
    float timer = 0.0f;
    private IEnumerator coroutine;
    private IEnumerator coroutine2;

    public AudioClip sonido_z = null;
    public AudioClip sonido_x = null;
    public AudioClip sonido_a = null;
    public AudioClip sonido_s = null;
    public AudioClip sonido_d = null;
    public AudioClip sonido_c = null;

    public AudioClip z = null;
    public AudioClip x = null;
    public AudioClip a = null;
    public AudioClip s = null;
    public AudioClip d = null;
    public AudioClip c = null;
    public AudioClip escucha = null;
    public AudioClip tu_turno = null;


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
        contador = 0;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (timer >= 4 && terminofase1)
        {
            //fase1(nivel);
            contador = 0;
            terminofase1 = false;
            coroutine = fase1(nivel);
            StartCoroutine(coroutine);
            timer = 0;
            terminofase2 = true;



        }

        if (timer >= 4 && terminofase2)
        {
            coroutine2 = fase2(nivel);
            StartCoroutine(coroutine2);


        }



    }



    IEnumerator esperar2(List<int> lis)
    {
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
            if (i == 6)
                GameObject.Find("Personaje6").GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(1);
            hola2(i);
        }
    }


    IEnumerator esperar3(int i)
    {

        yield return new WaitForSecondsRealtime(1);
        if (i == 1)
        {
            GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(z, new Vector3(0, 0, 0), 1);
            AudioSource.PlayClipAtPoint(sonido_z, new Vector3(0, 0, 0), 1);

        }
        if (i == 2)
        {
            GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(x, new Vector3(0, 0, 0), 1);
            AudioSource.PlayClipAtPoint(sonido_x, new Vector3(0, 0, 0), 1);

        }
        if (i == 3)
        {
            GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(a, new Vector3(0, 0, 0), 1);
            AudioSource.PlayClipAtPoint(sonido_a, new Vector3(0, 0, 0), 1);

        }
        if (i == 4)
        {
            GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(s, new Vector3(0, 0, 0), 1);
            AudioSource.PlayClipAtPoint(sonido_s, new Vector3(0, 0, 0), 1);

        }
        if (i == 5)
        {
            GameObject.Find("Personaje5").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(d, new Vector3(0, 0, 0), 1);
            AudioSource.PlayClipAtPoint(sonido_d, new Vector3(0, 0, 0), 1);

        }
        if (i == 6)
        {
            GameObject.Find("Personaje6").GetComponent<SpriteRenderer>().enabled = false;
            AudioSource.PlayClipAtPoint(c, new Vector3(0, 0, 0), 1);
            AudioSource.PlayClipAtPoint(sonido_c, new Vector3(0, 0, 0), 1);

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
        if (i ==6)
        {
            GameObject.Find("Personaje6").GetComponent<SpriteRenderer>().enabled = true;

        }



    }


    IEnumerator fase1(int nivel)
    {
        turno = true;
        random = UnityEngine.Random.Range(1, 7);
        if (primera_vez)
        {
            AudioSource.PlayClipAtPoint(escucha, new Vector3(0, 0, 0), 1);

            yield return new WaitForSeconds(1);
            primera_vez = false;
        }
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

        if (random == 6)
        {
            coroutine4 = esperar3(6);
            StartCoroutine(coroutine4);
            lista.Add(6);


        }






    }

    IEnumerator fase2(int nivel)
    {


        if (lista_jugador.Count == lista.Count)
        {


            lista_jugador.Clear();
            AudioSource.PlayClipAtPoint(escucha, new Vector3(0, 0, 0), 1);

            yield return new WaitForSeconds(1);

            foreach (var i in lista)
            {

                yield return new WaitForSecondsRealtime(1);
                if (i == 1)
                {
                    GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(z, new Vector3(0, 0, 0), 1);
                    AudioSource.PlayClipAtPoint(sonido_z, new Vector3(0, 0, 0), 1);

                }
                if (i == 2)
                {
                    GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(x, new Vector3(0, 0, 0), 1);
                    AudioSource.PlayClipAtPoint(sonido_x, new Vector3(0, 0, 0), 1);

                }
                if (i == 3)
                {
                    GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(a, new Vector3(0, 0, 0), 1);
                    AudioSource.PlayClipAtPoint(sonido_a, new Vector3(0, 0, 0), 1);

                }
                if (i == 4)
                {
                    GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(s, new Vector3(0, 0, 0), 1);
                    AudioSource.PlayClipAtPoint(sonido_s, new Vector3(0, 0, 0), 1);

                }
                if (i == 5)
                {
                    GameObject.Find("Personaje5").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(d, new Vector3(0, 0, 0), 1);
                    AudioSource.PlayClipAtPoint(sonido_d, new Vector3(0, 0, 0), 1);

                }
                if (i == 6)
                {
                    GameObject.Find("Personaje6").GetComponent<SpriteRenderer>().enabled = false;
                    AudioSource.PlayClipAtPoint(c, new Vector3(0, 0, 0), 1);
                    AudioSource.PlayClipAtPoint(sonido_c, new Vector3(0, 0, 0), 1);

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


        for (int i = 0; i < nivel; i++)
        {


            if (Input.GetKeyDown("z"))
            {
                nivel++;
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = true;


                lista_jugador.Add(1);
                AudioSource.PlayClipAtPoint(z, new Vector3(0, 0, 0), 1);
                AudioSource.PlayClipAtPoint(sonido_z, new Vector3(0, 0, 0), 1);

                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;
                if (!(lista.ElementAt(contador) == 1))
                {
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
                lista_jugador.Add(2);
                AudioSource.PlayClipAtPoint(x, new Vector3(0, 0, 0), 1);
                AudioSource.PlayClipAtPoint(sonido_x, new Vector3(0, 0, 0), 1);
                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;
                if (!(lista.ElementAt(contador) == 2))
                {
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
                lista_jugador.Add(3);
                AudioSource.PlayClipAtPoint(a, new Vector3(0, 0, 0), 1);
                AudioSource.PlayClipAtPoint(sonido_a, new Vector3(0, 0, 0), 1);
                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;
                if (!(lista.ElementAt(contador) == 3))
                {
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
                lista_jugador.Add(4);
                AudioSource.PlayClipAtPoint(s, new Vector3(0, 0, 0), 1);
                AudioSource.PlayClipAtPoint(sonido_s, new Vector3(0, 0, 0), 1);
                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;
                if (!(lista.ElementAt(contador) == 4))
                {
                    SceneManager.LoadScene("Perdio");

                }
                contador++;

            }

            if (Input.GetKeyDown("d"))
            {
                nivel++;
                GameObject.Find("Personaje5").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje5").GetComponent<SpriteRenderer>().enabled = true;
                lista_jugador.Add(5);
                AudioSource.PlayClipAtPoint(d, new Vector3(0, 0, 0), 1);
                AudioSource.PlayClipAtPoint(sonido_d, new Vector3(0, 0, 0), 1);
                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;
                if (!(lista.ElementAt(contador) == 5))
                {
                    SceneManager.LoadScene("Perdio");

                }
                contador++;

            }

            if (Input.GetKeyDown("c"))
            {
                nivel++;
                GameObject.Find("Personaje6").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje6").GetComponent<SpriteRenderer>().enabled = true;
                lista_jugador.Add(6);
                AudioSource.PlayClipAtPoint(c, new Vector3(0, 0, 0), 1);
                AudioSource.PlayClipAtPoint(sonido_c, new Vector3(0, 0, 0), 1);
                if (lista.Count == lista_jugador.Count)
                    timer = 1;
                else
                    timer = 1;
                if (!(lista.ElementAt(contador) == 6))
                {
                    SceneManager.LoadScene("Perdio");

                }
                contador++;

            }

        }//fin del for





    }
}
