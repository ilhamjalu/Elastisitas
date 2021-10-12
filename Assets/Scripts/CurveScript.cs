using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurveScript : MonoBehaviour
{
    public Slider p1, p2, q1, q2;
    public GameManager gm;
    public GameObject coor1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        p1.value = gm.numP1;
        p2.value = gm.numP2;
        q1.value = gm.numQ1;
        q2.value = gm.numQ2;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var a = coor1.gameObject.GetComponent<RectTransform>();

            //a.anchoredPosition = new Vector2(q1.handleRect.anchoredPosition.x, p1.handleRect.anchoredPosition.y);
            a.anchoredPosition = p1.handleRect.anchoredPosition;
        }
    }
}
