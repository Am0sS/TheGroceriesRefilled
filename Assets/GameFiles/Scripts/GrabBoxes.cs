using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabBoxes : MonoBehaviour
{
    // VARIABLES
    GameObject player;
    public GameObject instLoc;

    public GameObject dairyBox, houseHoldBox, vegAndFruitsBox, petFoodBox, drinkBox, paperBox, meatBox;
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
        var dairyInst = Instantiate(dairyBox, instLoc.transform.position, dairyBox.transform.rotation);
        dairyInst.transform.parent = player.transform;
        dairyInst.tag = "dairyBox";
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
        var houseHoldInst = Instantiate(houseHoldBox, instLoc.transform.position, houseHoldBox.transform.rotation);
        houseHoldInst.transform.parent = player.transform;
        houseHoldInst.tag = "houseHoldBox";
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
        var vegAndFruitInst = Instantiate(vegAndFruitsBox, instLoc.transform.position, vegAndFruitsBox.transform.rotation);
        vegAndFruitInst.transform.parent = player.transform;
        vegAndFruitInst.tag = "vegAndFruitBox";
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
        var petFoodInst = Instantiate(petFoodBox, instLoc.transform.position, petFoodBox.transform.rotation);
        petFoodInst.transform.parent = player.transform;
        petFoodInst.tag = "petFoodBox";
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
        var drinkInst = Instantiate(drinkBox, instLoc.transform.position, drinkBox.transform.rotation);
        drinkInst.transform.parent = player.transform;
        drinkInst.tag = "drinkBox";
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
        var paperInst = Instantiate(paperBox, instLoc.transform.position, paperBox.transform.rotation);
        paperInst.transform.parent = player.transform;
        paperInst.tag = "paperBox";
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
        var meatInst = Instantiate(meatBox, instLoc.transform.position, meatBox.transform.rotation);
        meatInst.transform.parent = player.transform;
        meatInst.tag = "meatBox";
        hasBox = true;
        RefillUI.SetActive(false);
        }
        else
        Debug.Log("You already have a box in your hand");
    }

}
