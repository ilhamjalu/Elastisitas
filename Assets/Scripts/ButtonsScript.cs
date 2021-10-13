using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public AudioSource bgm, sfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetString("sound") == "true")
        {
            bgm.mute = false;
            sfx.mute = false;
        }
        else
        {
            bgm.mute = true;
            sfx.mute = true;
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ElastisitasPenawaran()
    {
        SceneManager.LoadScene("Elastisitas_Penawaran");
    }

    public void ElastisitasPermintaan()
    {
        SceneManager.LoadScene("Elastisitas_Permintaan");
    }

    public void Performa()
    {
        SceneManager.LoadScene("Performa");
    }
}
