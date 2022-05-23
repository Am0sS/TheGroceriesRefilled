using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public GameObject RefillUI;
    void Start()
    {   
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player"))
        Destroy(GameObject.FindGameObjectWithTag("dairyBox"));
        Destroy(GameObject.FindGameObjectWithTag("houseHoldBox"));
        Destroy(GameObject.FindGameObjectWithTag("vegAndFruitBox"));
        Destroy(GameObject.FindGameObjectWithTag("petFoodBox"));
        Destroy(GameObject.FindGameObjectWithTag("drinkBox"));
        Destroy(GameObject.FindGameObjectWithTag("paperBox"));
        Destroy(GameObject.FindGameObjectWithTag("meatBox"));
        RefillUI.GetComponent<GrabBoxes>().hasBox = false;
    }
}
