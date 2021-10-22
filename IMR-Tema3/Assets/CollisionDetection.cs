using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject TargetHitText;
  
    private void OnTriggerEnter(Collider other)
    {
        TargetHitText.SetActive(true);
        Debug.Log("Mingea a intrat");

    }
}
