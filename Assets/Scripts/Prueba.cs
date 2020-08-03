using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prueba : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip sonido_z = null;
    public AudioClip sonido_x = null;
    public AudioClip sonido_a = null;
    public AudioClip sonido_s = null;
    public AudioClip sonido_d = null;
    public AudioClip sonido_c = null;

    int entrada;
    private IEnumerator corutine;
    float timer = 0.0f;
    bool terminorepetir;


    void Start()
    {
        entrada = 1;
        terminorepetir = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= .4 && terminorepetir) {
            corutine = repetir(entrada);
            StartCoroutine(corutine);
        }

        IEnumerator repetir(int entrada)
        {

//terminorepetir = true;
            if (Input.GetKeyDown("z"))
            {
                entrada++;
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje").GetComponent<SpriteRenderer>().enabled = true;



                Debug.Log("z");
                AudioSource.PlayClipAtPoint(sonido_z, new Vector3(0, 0, 0), 1);
                entrada = 1;

            }

            if (Input.GetKeyDown("x"))
            {
                entrada++;
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje2").GetComponent<SpriteRenderer>().enabled = true;

                Debug.Log("x");
                AudioSource.PlayClipAtPoint(sonido_x, new Vector3(0, 0, 0), 1);
                entrada = 1;

            }

            if (Input.GetKeyDown("a"))
            {
                entrada++;
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje3").GetComponent<SpriteRenderer>().enabled = true;

                Debug.Log("a");
                AudioSource.PlayClipAtPoint(sonido_a, new Vector3(0, 0, 0), 1);
                entrada = 1;

            }

            if (Input.GetKeyDown("s"))
            {
                entrada++;
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje4").GetComponent<SpriteRenderer>().enabled = true;

                Debug.Log("s");

                AudioSource.PlayClipAtPoint(sonido_s, new Vector3(0, 0, 0), 1);
                entrada = 1;

            }

            if (Input.GetKeyDown("d"))
            {
                entrada++;
                GameObject.Find("Personaje5").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje5").GetComponent<SpriteRenderer>().enabled = true;

                Debug.Log("d");

                AudioSource.PlayClipAtPoint(sonido_d, new Vector3(0, 0, 0), 1);
                entrada = 1;

            }

            if (Input.GetKeyDown("c"))
            {
                entrada++;
                GameObject.Find("Personaje6").GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSecondsRealtime(1);
                GameObject.Find("Personaje6").GetComponent<SpriteRenderer>().enabled = true;

                Debug.Log("c");

                AudioSource.PlayClipAtPoint(sonido_c, new Vector3(0, 0, 0), 1);
                entrada = 1;

            }
        }


        if (Input.GetKeyDown("backspace"))
        {
            SceneManager.LoadScene("Menu");
        }


        
    }

    




}
