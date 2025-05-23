using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin_Counter : MonoBehaviour
{
    public static Coin_Counter instance;

    public TMP_Text coinText;
    public int currentCoins = 0;
    
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "Coin Count: " + currentCoins.ToString();
    }

    // Update is called once per frame
    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = "Coin Count: " + currentCoins.ToString();
    }
}
