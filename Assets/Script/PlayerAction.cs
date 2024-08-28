using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;  

//kelas untuk player action seperti attacking, scope, dan Silent kill

public class PlayerAction : ExecuteLogic
{
    private PlayerActionInput inputActions;

    //supaya input action bisa digunakan
    private void Awake()
    {
        inputActions = new PlayerActionInput();
        inputActions.InputPlayerAction.Shooting.Enable();
    }

    private void Start()
    {
        //membuat event untuk menjalankan 'Shoot'
        inputActions.InputPlayerAction.Shooting.performed += Shooting_Performed;
    }

    //event ketika 'Shoot' dilakukan
    private void Shooting_Performed(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Shoot();
        }
        
    }    
    
}
