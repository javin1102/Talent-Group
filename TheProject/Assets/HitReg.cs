using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitReg : MonoBehaviour
{
    public AmmoCount ammo;
    private Crosshair crosshair;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ammo.LoseAmmo();
            //make some color when pressed or a instantiate
        }
    }
}
