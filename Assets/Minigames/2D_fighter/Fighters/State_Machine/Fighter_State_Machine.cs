using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class Fighter_State_Machine 
{

    public Fighter_State current_state;


    #region Constructor

    public Fighter_State_Machine()
    {

    }

    #endregion


    #region State Control 

    public void Set_New_State(Fighter_State new_state)
    {
        // Prepare old current state to transition, if not empty
        if (current_state != null)
            current_state.OnStateExit();


        current_state = new_state;
        //Debug.Log("New State:" + current_state);

        // Prepare new state for transition
        current_state.OnStateEnter();

    }


    // To be updated every frame

    public void Update_Current_State()
    {
        if (current_state != null)
        {
            current_state.OnStateUpdate();
        }
    }

    #endregion


}
