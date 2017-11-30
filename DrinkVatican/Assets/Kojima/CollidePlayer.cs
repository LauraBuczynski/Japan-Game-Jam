using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidePlayer : MonoBehaviour {

    GameObject test;

	// Use this for initialization
	void Start () {
        test = GameObject.Find("test");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friend":
                GetComponent<Drink>().DoDrink();
                break;
            case "Guard":
                test.GetComponent<ExitCondition>().Lose();
                break;
        }
    }
}
