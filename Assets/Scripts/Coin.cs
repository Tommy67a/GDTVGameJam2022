using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CarController playerCar = other.GetComponent<CarController>();

            if (playerCar != null)
            {
                playerCar.AddCoins();
            }

            Destroy(this.gameObject);
        }
    }
}
