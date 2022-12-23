using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class MovementOnHero : MonoBehaviour
    {
        public void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag == "SceneTransition")
            {
                SceneManager.LoadScene("Level2");
            }
            
            if (col.gameObject.tag == "Move_To_Menu")
            {
                SceneManager.LoadScene("MainMenu");
            }
            
        }
    }
}