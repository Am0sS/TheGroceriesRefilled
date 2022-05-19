using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryPicker : MonoBehaviour
{

    // VARIABLES
    public GameObject dairyP;
    public GameObject householdP;
    public GameObject vegetableAndFruitP;
    public GameObject petAndFoodP;
    public GameObject drinkP;
    public GameObject paperP;
    public GameObject meatP;
    void Start()
    {
        dairyP.SetActive(false);
        householdP.SetActive(false);
        vegetableAndFruitP.SetActive(false);
        petAndFoodP.SetActive(false);
        drinkP.SetActive(false);
        paperP.SetActive(false);
        meatP.SetActive(false);
    }


    public void ShowDairyP()
    {
        dairyP.SetActive(true);
        householdP.SetActive(false);
        vegetableAndFruitP.SetActive(false);
        petAndFoodP.SetActive(false);
        drinkP.SetActive(false);
        paperP.SetActive(false);
        meatP.SetActive(false);
    }
    public void ShowHouseHold()
    {
        dairyP.SetActive(false);
        householdP.SetActive(true);
        vegetableAndFruitP.SetActive(false);
        petAndFoodP.SetActive(false);
        drinkP.SetActive(false);
        paperP.SetActive(false);
        meatP.SetActive(false);
    }
    public void ShowVegetablesAndFruits()
    {
        dairyP.SetActive(false);
        householdP.SetActive(false);
        vegetableAndFruitP.SetActive(true);
        petAndFoodP.SetActive(false);
        drinkP.SetActive(false);
        paperP.SetActive(false);
        meatP.SetActive(false);
    }
    public void ShowPetFoods()
    {
        dairyP.SetActive(false);
        householdP.SetActive(false);
        vegetableAndFruitP.SetActive(false);
        petAndFoodP.SetActive(true);
        drinkP.SetActive(false);
        paperP.SetActive(false);
        meatP.SetActive(false);
    }
    public void ShowDrinks()
    {
        dairyP.SetActive(false);
        householdP.SetActive(false);
        vegetableAndFruitP.SetActive(false);
        petAndFoodP.SetActive(false);
        drinkP.SetActive(true);
        paperP.SetActive(false);
        meatP.SetActive(false);
    }
    public void ShowPapers()
    {
        dairyP.SetActive(false);
        householdP.SetActive(false);
        vegetableAndFruitP.SetActive(false);
        petAndFoodP.SetActive(false);
        drinkP.SetActive(false);
        paperP.SetActive(true);
        meatP.SetActive(false);
    }
    public void ShowMeats()
    {
        dairyP.SetActive(false);
        householdP.SetActive(false);
        vegetableAndFruitP.SetActive(false);
        petAndFoodP.SetActive(false);
        drinkP.SetActive(false);
        paperP.SetActive(false);
        meatP.SetActive(true);
    }

}
