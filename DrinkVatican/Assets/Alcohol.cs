using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alcohol : MonoBehaviour {

	//プレイヤーが飲んだかどうか
	bool m_isPlayerDrink = false;

	//フレンドが飲んだかどうか
	bool m_isFriendDrink = false;

	void Start ()
    {
		//アルコール数増加

	}

	void Update () {

	}

	//プレイヤーが飲む
	void DrinkPlayer()
    {
		m_isPlayerDrink = true;
	}

	//フレンドが飲む
	void DrinkFriend()
	{
		m_isFriendDrink = true;
	}

}
