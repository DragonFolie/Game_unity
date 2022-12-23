using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeroInputReader : MonoBehaviour
{
    [SerializeField] private HeroS _heroS ;


    


    /* Update is called once per frame
    private void Update()
    {


        var horizontal = Input.GetAxis("Horizontal");
        _heroS.SetHorizontalDirection(horizontal);

        if (Input.GetKey(KeyCode.A)){

            _heroS.SetHorizontalDirection(-1);

        }else if (Input.GetKey(KeyCode.D)){

            _heroS.SetHorizontalDirection(1);
        }
        else
        {
            _heroS.SetHorizontalDirection(0);
        }
      
    }*/


     public void OnHorizontalMovement(InputAction.CallbackContext context)
    {
        //Debug.Log("Some shit");

        var direction = context.ReadValue<float>();
        _heroS.SetHorizontalDirection(direction);

    }

    public void OnVerticalMovement(InputAction.CallbackContext context)
    {
        //Debug.Log("Some shit");

        var direction = context.ReadValue<float>();
        _heroS.SetVerticalDirection(direction);

    }


    public void OnSaySomethink(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Somethink");
        }

    }


}
