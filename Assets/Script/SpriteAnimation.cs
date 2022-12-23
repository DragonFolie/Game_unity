using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Script
{
    public class SpriteAnimation : MonoBehaviour
    {
        [SerializeField] private int _frameRate;
        [SerializeField] private bool _loop;
        [SerializeField] private Sprite[] _sprites;
        [SerializeField] private UnityEvent _onComplete;


        private SpriteRenderer _render;
        private float _secondPerFrame;
        private int _currentSprite;
        private float _nextFrameTime;




        private void Start()
        {
            _render = GetComponent<SpriteRenderer>();
            _secondPerFrame = 1f / _frameRate;
            _nextFrameTime = Time.time + _secondPerFrame;
        }

        private void Update()
        {
            if (_nextFrameTime > Time.time) return;
            _render.sprite = _sprites[_currentSprite];
            _nextFrameTime += _secondPerFrame;
            _currentSprite++;
        }




    }

    

}

