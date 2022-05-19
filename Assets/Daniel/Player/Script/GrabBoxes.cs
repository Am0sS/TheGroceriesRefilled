using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabBoxes : MonoBehaviour
{
    // VARIABLES
    GameObject player;
    public GameObject instLoc;

    public GameObject dairyBox, houseHoldBox, vegAndFruitBox, petFoodBox, drinkBox, paperBox, meatBox;
    public GameObject RefillUI;
    public bool hasBox;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        hasBox = false;
    }

    public void instDairyBox()
    {
        if (hasBox == false)
        {
        var dairyInst = Instantiate(dairyBox, instLoc.transform.position, Quaternion.identity);
        dairyInst.transform.parent = player.transform;
        hasBox = true;
        RefillUI.SetActive(false);
        }
        else
        Debug.Log("You already have a box in your hand");
    }
        public void instHouseholdBox()
    {
        if (hasBox == false)
        {
        var houseHoldInst = Instantiate(houseHoldBox, instLoc.transform.position, Quaternion.identity);
        houseHoldInst.transform.parent = player.transform;
        hasBox = true;
        RefillUI.SetActive(false);
        }
        else
        Debug.Log("You already have a box in your hand");
    }
        public void instvegAndFruitBox()
    {
        if (hasBox == false)
        {
        var vegAndFruitInst = Instantiate(vegAndFruitBox, instLoc.transform.position, Quaternion.identity);
        vegAndFruitInst.transform.parent = player.transform;
        hasBox = true;
        RefillUI.SetActive(false);
        }
        else
        Debug.Log("You already have a box in your hand");
    }
        public void instPetFoodBox()
    {
        if (hasBox == false)
        {
        var petFoodInst = Instantiate(petFoodBox, instLoc.transform.position, Quaternion.identity);
        petFoodInst.transform.parent = player.transform;
        hasBox = true;
        RefillUI.SetActive(false);
        }
        else
        Debug.Log("You already have a box in your hand");
    }
        public void instDrinkBox()
    {
        if (hasBox == false)
        {
        var drinkInst = Instantiate(drinkBox, instLoc.transform.position, Quaternion.identity);
        drinkInst.transform.parent = player.transform;
        hasBox = true;
        RefillUI.SetActive(false);
        }
        else
        Debug.Log("You already have a box in your hand");
    }
        public void instPaperBox()
    {
        if (hasBox == false)
        {
        var paperInst = Instantiate(paperBox, instLoc.transform.position, Quaternion.identity);
        paperInst.transform.parent = player.transform;
        hasBox = true;
        RefillUI.SetActive(false);
        }
        else
        Debug.Log("You already have a box in your hand");
    }
        public void instMeatBox()
    {
        if (hasBox == false)
        {
        var meatInst = Instantiate(meatBox, instLoc.transform.position, Quaternion.identity);
        meatInst.transform.parent = player.transform;
        hasBox = true;
        RefillUI.SetActive(false);
        }
        else
        Debug.Log("You already have a box in your hand");
    }

}
