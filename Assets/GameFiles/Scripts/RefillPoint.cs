using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RefillPoint : MonoBehaviour
{

    // VARIABLES
    public GameObject RefillUI;
    public GameObject mainCam;
    bool isInUI;
    void Start()
    {
        RefillUI.SetActive(false);
        isInUI = false;
    }

    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && isInUI == false && RefillUI.GetComponent<GrabBoxes>().hasBox == false)
            {
                RefillUI.SetActive(true);
                isInUI = true;
                Cursor.lockState = CursorLockMode.None;
                mainCam.GetComponent<CameraMovement>().enabled = false;
            }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && isInUI == true)
            {
                RefillUI.SetActive(false);
                isInUI = false;
                Cursor.lockState = CursorLockMode.Locked;
                mainCam.GetComponent<CameraMovement>().enabled = true;
            }

    }
}
