using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCondition : MonoBehaviour {
    
    bool m_IsWin = false;
    bool m_IsLose = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // drink 3 time && gift 3 time
        if (GetComponent<DrinkCounter>().GetDrinkCount() > 3 &&
            GetComponent<DrinkCounter>().GetGiftCount() > 3)
        {
            Win();
        }
	}

    void Win()
    {
        m_IsWin = true;
    }
    void Lose()
    {
        m_IsLose = true;
    }
}
