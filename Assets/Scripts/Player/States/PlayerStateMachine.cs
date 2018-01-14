using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum StateID
{
    Idle,
    Moving,
    InAir
}

public class PlayerStateMachine : MonoBehaviour {

	private readonly Dictionary<StateID, PlayerState> playerStates = new Dictionary<StateID, PlayerState>();

	private PlayerState currentState;

	void Start()
    {
        AddState(StateID.Idle, GetComponent<PlayerStateIdle>());
        AddState(StateID.Moving, GetComponent<PlayerStateMoving>());
        AddState(StateID.InAir, GetComponent<PlayerStateInAir>());
    }

	void Update()
    {
        if (currentState != null)
        {
            currentState.Reason();
            currentState.Act();
        }

    }

    public void SetState(StateID stateID)
    {

        if (!playerStates.ContainsKey(stateID))
            return;

        if (currentState != null)
            currentState.Leave();

        currentState = playerStates[stateID];

        currentState.Enter();
    }

	public void AddState(StateID stateID, PlayerState state)
    {
        playerStates.Add(stateID, state);
    }
}
