using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public GameObject QuitGameUI;
    public GameObject player;
    public GameObject mainCam;

    void Start()
    { 

    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Door"))
        {
            mainCam.GetComponent<CameraMovement>().enabled = false;
            player.GetComponent<PlayerMovement>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            QuitGameUI.SetActive(true);
        }
    }


}
