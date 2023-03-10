using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script.Component
{
    public class EnterTriggerComponent : MonoBehaviour
    {
        [SerializeField] private string _tag;
        [SerializeField] private UnityEvent _action;


        private void OnTriggerEnter2D(Collider2D other)
        {
            
            if (other.gameObject.CompareTag(_tag))
            {
                
                if (_action != null)
                {
                    
                    _action.Invoke();
                }
            }
        }
    }
}
