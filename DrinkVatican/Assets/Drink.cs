using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink : MonoBehaviour {

	void Start () {

	}

	void Update (){
        
	}

    //void Drink()
    //Do not bacome aconstructor
    public void DoDrink()
    {
        GetComponent<DrinkCounter>().PlusDrinkCount();
    }

    public void Gift()
    {
        GetComponent<DrinkCounter>().PlusGiftCount();
    }
}
