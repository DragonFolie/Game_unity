using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class EnterTriggerComponent : MonoBehaviour
{
    [SerializeField] private string _tag;
    [SerializeField] private UnityEvent uniteEvent;


    private void OnTriggerEnter2D(Collider2D other)
    { 
      if(other.gameObject.CompareTag(_tag))
        {

        }
    }
}
