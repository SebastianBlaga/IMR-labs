using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HandAnimation : MonoBehaviour
{
    
    Animator animator;
    public XRController controller = null;

    void Start()
    {
        animator.GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool grip))
        {
            animator.SetBool("Grip", true);
        }
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool trigger))
        {
            animator.SetBool("Trigger", true);
        }
    }


}


