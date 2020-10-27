using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCount : MonoBehaviour
{
    public Image[] ammo;
    public int ammoRemaining;

    public void LoseAmmo()
    {
        if (ammoRemaining == 0) return;

        //Decrease the ammoRemaining
        ammoRemaining--;
        //Hide one of the ammo
        ammo[ammoRemaining].enabled = false;

        //if ammo=0, lose game
        if (ammoRemaining == 0)
        {
            Debug.Log("Lose");
        }
    }
}
