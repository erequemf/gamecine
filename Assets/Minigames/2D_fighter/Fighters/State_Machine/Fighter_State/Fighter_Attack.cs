using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter_Attack : Fighter_State
{

    public Fighter_Attack(Fighter new_fighter, Fighter_State_Machine new_state_machine) : base(new_fighter, new_state_machine) { }


    public override void OnStateEnter()
    {
        base.OnStateEnter();

        // Start Animation

        fighter.anim_control.SetTrigger("Attack");

    }


}
