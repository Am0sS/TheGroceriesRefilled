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
    public GameObject RefillUI;
    public GameObject boxIsntRightText;
    public GameObject refillingText;


    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        productPercent = 100f;
        boxIsntRightText.SetActive(false);
        refillingText.SetActive(false);
    }

    void Update()
    {
        productPercent -= 1f * Time.deltaTime;

        if (productPercent <= minPercent)
            correspondingShelf.SetActive(false);
        else if (productPercent >= maxPercent)
            productPercent = 100f;

        text.text = ($"{Mathf.Round(productPercent).ToString()} %");
        if (productPercent <= 50)
            text.color = Color.red;
        else  
            text.color = Color.black;



    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(typeRequired))
        {
            StartCoroutine(FillUp());
            StartCoroutine(RefillingText());
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            return;
        }
        else 
           StartCoroutine(NotRightBox());
    }

    IEnumerator FillUp()
    {
        mainCam.GetComponent<CameraMovement>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;

        yield return new WaitForSeconds(4f);
        productPercent += 25f;
        Destroy(GameObject.FindGameObjectWithTag("dairyBox"));
        Destroy(GameObject.FindGameObjectWithTag("houseHoldBox"));
        Destroy(GameObject.FindGameObjectWithTag("vegAndFruitBox"));
        Destroy(GameObject.FindGameObjectWithTag("petFoodBox"));
        Destroy(GameObject.FindGameObjectWithTag("drinkBox"));
        Destroy(GameObject.FindGameObjectWithTag("paperBox"));
        Destroy(GameObject.FindGameObjectWithTag("meatBox"));
        mainCam.GetComponent<CameraMovement>().enabled = true;
        player.GetComponent<PlayerMovement>().enabled = true;
        RefillUI.GetComponent<GrabBoxes>().hasBox = false;
    }

    IEnumerator RefillingText()
    {
        refillingText.SetActive(true);
        yield return new WaitForSeconds(4f);
        refillingText.SetActive(false);
    }

    IEnumerator NotRightBox()
    {
        boxIsntRightText.SetActive(true);
        yield return new WaitForSeconds(1f);
        boxIsntRightText.SetActive(false);

    }
}
