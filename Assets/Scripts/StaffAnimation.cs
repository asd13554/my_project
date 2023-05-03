using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffAnimation : MonoBehaviour
{
    private Animator anim;
    private Staff staff;
    
    void Awake()
    {
        anim = GetComponent<Animator>();
        staff = GetComponent<Staff>();
    }

    // Update is called once per frame
    void Update()
    {
        if (staff.State == UnitState.Idle)
        {
            DisableAll();
            anim.SetBool("isIdle", true);
        }

        if (staff.State == UnitState.Walk)
        {
            DisableAll();
            anim.SetBool("isWalk", true);
        }
        if (staff.State == UnitState.Plow)
        {
            DisableAll();
            anim.SetBool("isPlow", true);
        }
        
        if (staff.State == UnitState.Sow)
        {
            DisableAll();
            anim.SetBool("isSow", true);
        }
        
        if (staff.State == UnitState.Harvest)
        {
            DisableAll();
            anim.SetBool("isHarvest", true);
        }
        
        if (staff.State == UnitState.Water)
        {
            DisableAll();
            anim.SetBool("isWater", true);
        }
    }

    private void DisableAll()
    {
        anim.SetBool("isIdle", false);
        anim.SetBool("isWalk", false);
        anim.SetBool("isPlow", false);
        anim.SetBool("isSow", false);
        anim.SetBool("isHarvest", false);
        anim.SetBool("isWater", false);
    }
}
