using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;
public class LayerScript : MonoBehaviour
{
    [SerializeField] private LayerMask _groundLayer;
    private Collider2D _collider;

    public bool isTouching;

    private void Awake()
    {

        _collider = GetComponent<Collider2D>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {

        isTouching = _collider.IsTouchingLayers(_groundLayer);
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        isTouching = _collider.IsTouchingLayers(_groundLayer);
    }

}
