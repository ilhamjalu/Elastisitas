using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_InputField p1, p2, q1, q2, nKoefisien, jKurva, deltaP, deltaQ;
    public float numP1, numP2, numQ1, numQ2, totP, totQ;
    float koef;
    public GameObject firstPos, secPos, panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(p1.text != "" && p2.text != "")
        //    DeltaP();

        //if (q1.text != "" && q2.text != "")
        //    DeltaQ();

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    koef = (totQ / totP) * (numP1 / numQ1);
        //    Debug.Log(koef);
        //    nKoefisien.text = koef.ToString();
        //    JenisKurva();
        //}
            
    }

    public void Mulai()
    {
        int i = 0;

        if (koef > 1)
            i = 1;
        else if (koef < 1)
            i = 3;
        else if (koef == 1)
            i = 2;
        else if (koef == 0)
            i = 0;
        else
            i = 0;

        if (numP1 > numP2)
        {
            firstPos.transform.position = new Vector2(firstPos.transform.position.x, firstPos.transform.position.y + i);
        }
        else if (numP2 > numP1)
        {
            secPos.transform.position = new Vector2(secPos.transform.position.x, secPos.transform.position.y + i);
        }

        if(numQ1 > numQ2)
        {
            firstPos.transform.position = new Vector2(firstPos.transform.position.x + i, firstPos.transform.position.y);
        }
        else if (numQ2 > numQ1)
        {
            secPos.transform.position = new Vector2(secPos.transform.position.x + i, secPos.transform.position.y);
        }


    }

    public void ResetButton()
    {
        p1.text = "";
        p2.text = "";
        q1.text = "";
        q2.text = "";
        deltaP.text = "";
        deltaQ.text = "";
        nKoefisien.text = "";
        jKurva.text = "";
    }

    public void DeltaP()
    {
        numP1 = float.Parse(p1.text);
        numP2 = float.Parse(p2.text);
        totP = numP2 - numP1;

        deltaP.text = totP.ToString();
    }

    public void DeltaQ()
    {
        numQ1 = float.Parse(q1.text);
        numQ2 = float.Parse(q2.text);
        totQ = numQ2 - numQ1;

        deltaQ.text = totQ.ToString();
    }

    public void JenisKurva()
    {
        if (koef > 1)
            jKurva.text = "Elastis";
        else if(koef < 1)
            jKurva.text = "Inelastis";
        else if (koef == 1)
            jKurva.text = "Elastis Uniter";
        else if (koef == 0)
            jKurva.text = "Inelastis Sempurna";
        else
            jKurva.text = "Elastis Sempurna";

    }

    public void Koefisien()
    {
        koef = (totQ / totP) * (numP1 / numQ1);
        Debug.Log(koef);
        nKoefisien.text = koef.ToString();
    }

    public void HidePanel()
    {
        panel.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
