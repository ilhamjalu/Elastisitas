using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsCode : MonoBehaviour
{
    Animator anim;
    public bool next = false, prev = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(next == true)
        {
            anim.SetBool("Next", true);
            anim.SetBool("Prev", false);
            next = false;
        }
        if (prev == true)
        {
            anim.SetBool("Prev", true);
            anim.SetBool("Next", false);
            next = true;
        }
    }
}
