using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RefillPoint : MonoBehaviour
{

    // VARIABLES
    GameObject RefillUI;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
            Debug.Log("In Collision");
    }
}
