using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardChaseState : State<Guard>
{
	//コンストラクタ
	public GuardChaseState(Guard obj) : base(obj) { }

	Rigidbody m_rb;
	SeeController m_seeControl;

	/// <summary>
	/// 開始処理
	/// </summary>
	public override void Enter()
	{
		m_rb = obj.GetComponent<Rigidbody>();
		m_seeControl = obj.GetComponent<SeeController>();
	}

	/// <summary>
	/// 実行処理
	/// </summary>
	public override void Execute()
	{
		Vector3 dir = m_seeControl.GetPlayer().transform.position - obj.transform.position;
		dir.Normalize();

		SimpleMove.SimpleMoving(obj.gameObject, m_rb, dir * obj.CHASE_SPEED);

		if (!m_seeControl.IsLook()){
			//状態切替
			obj.ChangeState(GUARD_STATE.ROAM);
		}
	}


	/// <summary>
	/// 終了処理
	/// </summary>
	public override void Exit()
	{

	}
}
