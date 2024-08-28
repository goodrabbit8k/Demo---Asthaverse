using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;  

//kelas untuk player action seperti attacking, scope, dan Silent kill

public class PlayerAction : MonoBehaviour
{
    private PlayerActionInput inputActions;
    private bool isShooting = false;

    //supaya input action bisa digunakan
    private void Awake()
    {
        inputActions = new PlayerActionInput();
        inputActions.InputPlayerAction.Shooting.Enable();
    }

    private void Start()
    {
        inputActions.InputPlayerAction.Shooting.performed += Shooting_Performed;
    }

    private void Shooting_Performed(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Debug.Log("Shoot");
        }
        
    }

    //untuk parsing value float ketika memencet tombol Shoot (T-T value nya float dia)
    
}
