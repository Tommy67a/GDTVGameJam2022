using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text coinText;

    public void UpdateCoinDisplay(int coins)
    {
        coinText.text = "Coins: " + coins.ToString();
    }
}
