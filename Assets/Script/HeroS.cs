using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class HeroS : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private float _jumpSpeed;
    // [SerializeField] private LayerMask _groundLayer;

    [SerializeField] private  LayerScript _groundCheck;
    [SerializeField] private float _groundCheckRadius;
    [SerializeField] private Vector3 _groundCheckPositionDelta;


    private float _Hdirection;
    private float _Vdirection;

    private Rigidbody2D _rigitBody;
    private Animator _animator;
    private SpriteRenderer _sprite;


    private static readonly int IsRunningKey = Animator.StringToHash("IsRunning");
    private static readonly int isGroundKey = Animator.StringToHash("IsGround");
    private static readonly int VerticalVelocityKey = Animator.StringToHash("VerticalVelocity");

    private void Awake()
    {

        _rigitBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _sprite = GetComponent<SpriteRenderer>();
    }


    private void FixedUpdate()
    {

        _rigitBody.velocity = new Vector2(_Hdirection * _speed, _rigitBody.velocity.y);
        var isGrounded = isGround();

        var isJumping = _Vdirection > 0;
        if (isJumping && isGrounded)
        {
            _rigitBody.AddForce(Vector2.up * _jumpSpeed, ForceMode2D.Impulse);
        }


        _animator.SetBool(isGroundKey, isGrounded);
        _animator.SetBool(IsRunningKey, _Hdirection != 0);
        _animator.SetFloat(VerticalVelocityKey, _rigitBody.velocity.y);

        if(_Hdirection > 0)
        {
            _sprite.flipX = false;
        }else if(_Hdirection < 0)
        {
            _sprite.flipX = true;
        }
    }


    private bool isGround()
    {

        return _groundCheck.isTouching;


        //var hit = Physics2D.CircleCast(transform.position + _groundCheckPositionDelta,_groundCheckRadius,Vector2.down,0,_groundLayer);
       // return hit.collider != null;
        

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = isGround() ? Color.green : Color.red;

        Gizmos.DrawSphere(transform.position , 0.3f);

         Gizmos.DrawSphere(transform.position + _groundCheckPositionDelta, _groundCheckRadius);
        //Debug.DrawRay(transform.position, Vector3.down, isGround() ? Color.green : Color.red);
    }

    public void SetHorizontalDirection(float direction)
    {

        _Hdirection = direction;

        /*  Debug.Log("Hor= " + _Hdirection);
          Debug.Log("Ver= " + _Vdirection);*/
    }

    public void SetVerticalDirection(float direction)
    {

        _Vdirection = direction;

        /* Debug.Log("Ver= " + _Vdirection);
         Debug.Log("Hor= " + _Hdirection);*/
    }

    /*private void Update()
    {
        
        

            

            var hDelta = _Hdirection * _speed * Time.deltaTime;
            var vDelta = _Vdirection * _speed * Time.deltaTime;

            var newXposition = transform.position.x + hDelta;
            var newYposition = transform.position.y + vDelta;

            //Debug.Log(newXposition + "   -UPD--  " + newYposition);


            transform.position = new Vector3(newXposition, newYposition, transform.position.z);
            
        
        
    }*/



}
