using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkCounter : MonoBehaviour {

    //飲んだ回数
    private int m_drinkCount = 0;

    //アルコールの数
    private int m_alcoholCount = 0;

    //フレンドに渡した回数
    private int m_giftCount = 0;

    void Start() {

    }

    void Update() {

    }

    public void PlusDrinkCount()
    {
        m_drinkCount++;
    }

    public void PlusGiftCount()
    {
        m_giftCount++;
    }

    public int GetDrinkCount()
    {
        return m_drinkCount;
    }

    public int GetAlcoholCount()
    {
        return m_alcoholCount;
    }

    public int GetGiftCount()
    {
        return m_giftCount;
    }
}
