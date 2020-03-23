using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class Fighter_Idle : Fighter_State
{

    public Fighter_Idle(Fighter new_fighter, Fighter_State_Machine new_state_machine) : base(new_fighter, new_state_machine) { }


    public override void OnStateUpdate()

    {
        base.OnStateUpdate();


        #region Transitions

        // To Attack

        if ( fighter.attack_act)
        {
            state_machine.Set_New_State(fighter.state_attack);
            return;
        }

        // To walk

        if ( fighter.movement_dir != Vector2.zero)
        {
            state_machine.Set_New_State(fighter.state_walk);
            return;
        }



        #endregion

    }
}
