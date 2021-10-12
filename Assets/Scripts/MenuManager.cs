using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public List<GameObject> item;
    public Animator anim;
    bool butNext = false, butPrev = false;
    public AnimationsCode itemAnim;
    int i = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(i);
        //itemAnim = item[i].GetComponent<AnimationsCode>();
        if (butNext == true)
        {
            butNext = false;
            anim = item[i].GetComponent<Animator>();

            anim.SetBool("Next", true);
            anim.SetBool("Prev", false);

        }
        else if (butPrev == true)
        {
            butPrev = false;
            anim = item[i].GetComponent<Animator>();

            anim.SetBool("Prev", true);
            anim.SetBool("Next", false);
        }

    }

    public void NextButton()
    {
        //itemAnim.next = true;
        //i += 1;
        anim = item[i].GetComponent<Animator>();

        anim.SetBool("Next", true);
        anim.SetBool("Prev", false);

        //butNext = true;

        //i += 1;
        StartCoroutine(Next());
    }

    IEnumerator Next()
    {
        yield return new WaitForSeconds(0.5f);

        i += 1;
        
        if (i > 3)
        {
            //i = 3;
            SceneManager.LoadScene("Elastisitas_Permintaan");
        }

        anim = item[i].GetComponent<Animator>();

        anim.SetBool("Next", true);
        anim.SetBool("Prev", false);
    }

    public void PrevButton()
    {
        anim = item[i].GetComponent<Animator>();

        anim.SetBool("Prev", true);
        anim.SetBool("Next", false);

        //butPrev = true;

        //i -= 1;
        StartCoroutine(Prev());
    }

    IEnumerator Prev()
    {
        yield return new WaitForSeconds(0.5f);

        i -= 1;

        if (i <= 0)
            i = 0;

        if (i == 0)
        {
            anim = item[i].GetComponent<Animator>();

            anim.SetBool("Prev", true);
            anim.SetBool("Next", false);
        }
        //anim = item[i].GetComponent<Animator>();

        //anim.SetBool("Prev", true);
        //anim.SetBool("Next", false);
    }

    public void Informasi()
    {
        for(int a = 0; a <= 2; a++)
        {
            NextButton();
        }
    }

    public void ButtonPermintaan()
    {
        SceneManager.LoadScene("Elastisitas_Permintaan");
    }

    public void ButtonPenawaran()
    {
        SceneManager.LoadScene("Elastisitas_Penawaran");
    }

    public void ButtonPerforma()
    {
        SceneManager.LoadScene("Performa");
    }

    public void ButtonQuit()
    {
        Application.Quit();
    }
}
