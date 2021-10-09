using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Actions : MonoBehaviour
{

    Animator animator;
    public float threshold;
    Transform cactusOne;
    Transform cactusTwo;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        cactusOne = GameObject.Find("ImageTarget_1").transform;
        cactusTwo = GameObject.Find("ImageTarget_2").transform;
        if (Vector3.Distance(cactusOne.position, cactusTwo.position) <= threshold)
            {
            animator.SetBool("atack", true);
            
        }
        else
        {
            animator.SetBool("atack", false);
            
        }
    }
}
