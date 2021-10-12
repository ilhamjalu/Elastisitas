using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    public Transform[] points;
    public LineManager line;

    // Start is called before the first frame update
    void Start()
    {
        line.SetUpLine(points);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
