using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class NavCollider : MonoBehaviour
{

    private SetCounter setCounter;

    private void Start()
    {
        setCounter = GameObject.FindObjectOfType<SetCounter>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Artifact") && gameObject.CompareTag("Explorer"))
        {
            setCounter.IncrementCounter();
        }
    }

}



