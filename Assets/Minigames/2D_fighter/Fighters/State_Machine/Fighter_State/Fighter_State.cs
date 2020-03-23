using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public abstract class Fighter_State 
{

    protected Fighter fighter;
    protected Fighter_State_Machine state_machine;

    // Construct
    public Fighter_State( Fighter new_fighter, Fighter_State_Machine new_state_machine )
    {
        fighter = new_fighter;
        state_machine = new_state_machine;
    }


    #region State Operation


    public virtual void OnStateEnter()
    {
       
    }

    public virtual void OnStateUpdate()
    {

    }


    public virtual void OnStateExit()
    {

    }


    #endregion


}
