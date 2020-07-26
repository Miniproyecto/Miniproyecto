using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Niveles : MonoBehaviour
{
    // Start is called before the first frame update
    float timer= 0.0f;
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
                SceneManager.LoadScene("SampleScene");
            }

            if (timer > 10 && timer < 20)
            {
                SceneManager.LoadScene("nivel2");
            }

            if (timer > 20 && timer < 30)
            {
                SceneManager.LoadScene("nivel3");
            }
        }

        if (Input.GetKeyDown("backspace"))
        {
            SceneManager.LoadScene("Menu");
        }

        GameObject.Find("Tiempo").GetComponent<Text>().text = "Tiempo: " + timer;

        if (timer < 10)
            GameObject.Find("Accion").GetComponent<Text>().text = "Accion: Nivel 1";
        if (timer > 10 && timer < 20)
            GameObject.Find("Accion").GetComponent<Text>().text = "Accion: Nivel 2";
        if (timer > 20 && timer < 30)
            GameObject.Find("Accion").GetComponent<Text>().text = "Accion: Nivel 3";

        if (timer > 30)
            timer = 0;

        


        
    }
}
