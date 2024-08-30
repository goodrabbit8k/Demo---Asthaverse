using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* PERHATIAN!!!
 * Kalo mau akses logic di skrip ini
 * Public class nya extend ke class ini
 * Jangan ke MonoBehaviour
 */
public class ExecuteLogic : WeaponType
{

    //setelah di extend, klean bisa make function ini tanpa perlu refrence

    //logic 'Shoot'
    public void Shoot(GameObject gameObject)
    {
        ExecuteShooting(gameObject);
    }    

    public void ChangingWeapon()
    {
        Debug.Log("WeaponChanged");
    }

    //logic 'SilentKill'
    public void SilentKill()
    {
        SilentKill silentKill = GetComponentInChildren<SilentKill>();
        silentKill.canKill = true;
    }

}
