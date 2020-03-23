using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fighter : MonoBehaviour
{

    #region Fighter State Management

    protected enum FIGHTER_STATES
    {
        IDLE,
        WALK,
        ATTACK,
        DEFENSE,
        DAMAGED,
        DEATH
    }

    [SerializeField]
    protected Fighter_State_Machine state_machine;

    // States
    public Fighter_Idle state_idle;

    public Fighter_Walk state_walk;

    public Fighter_Attack state_attack;
    #endregion


    #region Input Variables

    public Vector2 movement_dir = new Vector2();

    public bool attack_act = false;

    public bool defense_act = false;

    #endregion

    
    #region Components

    public Animator anim_control;

    public CharacterController char_control;

    #endregion


    #region Movement Parameters

    public float walk_speed = .6f;

    #endregion



    // Get parameters
    protected virtual void Start()
    {

        // Create State Machine & States

        state_machine = new Fighter_State_Machine();

        state_idle = new Fighter_Idle(this, state_machine);

        state_walk = new Fighter_Walk(this, state_machine);

        state_attack = new Fighter_Attack(this, state_machine);

        // Starter with idle

        this.Set_to_Idle_State();

        // Auto Get Components

        anim_control = GetComponent<Animator>();

        char_control = GetComponent<CharacterController>();

    }

    //  Function to set input each frame
    protected virtual void Update()
    {
        state_machine.Update_Current_State();
    }


    public void Set_to_Idle_State()
    {
        state_machine.Set_New_State(state_idle);
    }
}
