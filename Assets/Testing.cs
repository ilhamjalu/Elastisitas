using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    RectTransform rt;
    public Vector3 curPos, startPos;
    public float speed;
    float startTime, lerp;

    // Start is called before the first frame update
    void Start()
    {
        rt.GetComponent<RectTransform>();
        startPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        NextButton();
    }

    public void NextButton()
    {
        startTime += Time.deltaTime;
        float a = startTime / speed;

        transform.localPosition = Vector3.Lerp(startPos, curPos, a);
    }
}
