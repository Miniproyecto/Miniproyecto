using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instrucciones : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 0.0f;
    public AudioClip pausa = null;
    public AudioClip a = null;
    public AudioClip s = null;
    public AudioClip d = null;
    public AudioClip z = null;
    public AudioClip x = null;
    public AudioClip c = null;
    public AudioClip sonido_a = null;
    public AudioClip sonido_s = null;
    public AudioClip sonido_d = null;
    public AudioClip sonido_z = null;
    public AudioClip sonido_x = null;
    public AudioClip sonido_c = null;

    bool reproducirPausa = true;
    bool reproducira = true;
    bool reproduciraa = true;
    bool reproducirs = true;
    bool reproducirss = true;
    bool reproducird = true;
    bool reproducirdd = true;
    bool reproducirz = true;
    bool reproducirzz = true;
    bool reproducirx = true;
    bool reproducirxx = true;
    bool reproducirc = true;
    bool reproducircc = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if ( timer < 21 && reproducirPausa )
        {
            AudioSource.PlayClipAtPoint(pausa, new Vector3(0, 0, 0), 1);
            reproducirPausa = false;
        }

        if(timer >21 && timer < 25 && reproducira)
        {
            AudioSource.PlayClipAtPoint(a, new Vector3(0, 0, 0), 1);
            reproducira = false;

        }

        if (timer > 25 && timer < 29 && reproduciraa)
        {
            AudioSource.PlayClipAtPoint(sonido_a, new Vector3(0, 0, 0), 1);
            reproduciraa = false;
        }

        if (timer > 29 && timer < 33 && reproducirs)
        {
            AudioSource.PlayClipAtPoint(s, new Vector3(0, 0, 0), 1);
            reproducirs = false;
        }

        if (timer > 33 && timer < 37 && reproducirss)
        {
            AudioSource.PlayClipAtPoint(sonido_s, new Vector3(0, 0, 0), 1);
            reproducirss = false;
        }

        if (timer > 37 && timer < 41 && reproducird)
        {
            AudioSource.PlayClipAtPoint(d, new Vector3(0, 0, 0), 1);
            reproducird = false;
        }

        if (timer > 41 && timer < 45 && reproducirdd)
        {
            AudioSource.PlayClipAtPoint(sonido_d, new Vector3(0, 0, 0), 1);
            reproducirdd = false;
        }

        if (timer > 45 && timer < 49 && reproducirz)
        {
            AudioSource.PlayClipAtPoint(z, new Vector3(0, 0, 0), 1);
            reproducirz = false;
        }
        if (timer > 49 && timer < 53 && reproducirzz)
        {
            AudioSource.PlayClipAtPoint(sonido_z, new Vector3(0, 0, 0), 1);
            reproducirzz = false;
        }
        if (timer > 53 && timer < 57 && reproducirx)
        {
            AudioSource.PlayClipAtPoint(x, new Vector3(0, 0, 0), 1);
            reproducirx = false;
        }
        if (timer > 57 && timer < 61 && reproducirxx)
        {
            AudioSource.PlayClipAtPoint(sonido_x, new Vector3(0, 0, 0), 1);
            reproducirxx = false;
        }
        if (timer > 61 && timer < 65 && reproducirc)
        {
            AudioSource.PlayClipAtPoint(c, new Vector3(0, 0, 0), 1);
            reproducirc = false;
        }
        if (timer > 65 && reproducircc)
        {
            AudioSource.PlayClipAtPoint(sonido_c, new Vector3(0, 0, 0), 1);
            reproducircc = false;
        }

        if(timer > 70)
        {
            timer = 0;
             reproducirPausa = true;
             reproducira = true;
             reproduciraa = true;
             reproducirs = true;
             reproducirss = true;
             reproducird = true;
             reproducirdd = true;
             reproducirz = true;
             reproducirzz = true;
             reproducirx = true;
             reproducirxx = true;
             reproducirc = true;
             reproducircc = true;
        }


        if (Input.GetKeyDown("backspace"))
        {
            SceneManager.LoadScene("Menu");
        }



    }
}
