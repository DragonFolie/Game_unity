using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Script.Component
{
    public class CoinCounter : MonoBehaviour
    {

        public static int coinCount;
        public void coinCounter()
        {
            coinCount++;
            Debug.Log(coinCount);
        }
    }
}