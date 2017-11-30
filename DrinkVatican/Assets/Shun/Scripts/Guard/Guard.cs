using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GUARD_STATE
{
	ROAM,
	CHASE,
}

public class Guard : StateObjectBase<Guard, GUARD_STATE>
{
	[SerializeField]
	private float m_maxSpd = 2.0f;

	public float MAX_SPEED{
		get { return m_maxSpd; }
	}

	protected override void Start () {
		base.Start();
		stateList.Add(new GuardRoamState(this));
		stateList.Add(new GuardChaseState(this));

		stateMachine = new StateMachine<Guard>();
		ChangeState(GUARD_STATE.ROAM);
	}

	protected override void Update () {
		base.Update();
	}
}
