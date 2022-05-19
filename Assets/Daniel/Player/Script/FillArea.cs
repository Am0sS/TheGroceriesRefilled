using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FillArea : MonoBehaviour
{
    public string typeRequired;
    GameObject player;
    public GameObject mainCam;
    public GameObject correspondingShelf;
    float productPercent;
    float minPercent = 0f;
    float maxPercent = 100f;
    public TextMeshPro text;
    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        productPercent = 100f;
    }

    void Update()
    {
        productPercent -= 1f * Time.deltaTime;

        if (productPercent <= minPercent)
            correspondingShelf.SetActive(false);
        else if (productPercent >= maxPercent)
            productPercent = 100f;

        text.text = (productPercent.ToString());

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(typeRequired))
            StartCoroutine(FillUp());
        else 
            Debug.Log("The products in this box don't belong to this shelf");
    }

    IEnumerator FillUp()
    {
        mainCam.GetComponent<CameraMovement>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        yield return new WaitForSeconds(4f);
        productPercent += 25f;
        mainCam.GetComponent<CameraMovement>().enabled = true;
        player.GetComponent<PlayerMovement>().enabled = true;


    }
}
