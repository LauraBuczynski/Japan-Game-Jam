using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardRoamState : State<Guard>
{
	//コンストラクタ
	public GuardRoamState(Guard obj) : base(obj) { }

	Rigidbody m_rb;
	SeeController m_seeControl;

	float m_timer = 3.0f;

	/// <summary>
	/// 開始処理
	/// </summary>
	public override void Enter(){
		m_rb = obj.GetComponent<Rigidbody>();
		m_seeControl = obj.GetComponent<SeeController>();
	}

	/// <summary>
	/// 実行処理
	/// </summary>
	public override void Execute(){
		m_timer += Time.deltaTime;
		if (m_timer >= 3.0)
		{
			m_timer = 0.0f;
			SimpleMove.RoamMoving(obj.gameObject, m_rb,obj.MAX_SPEED);
		}


		if (m_seeControl.IsLook()){
			Debug.Log("CHANGE");

			//状態切替
			obj.ChangeState(GUARD_STATE.CHASE);
		}
	}


	/// <summary>
	/// 終了処理
	/// </summary>
	public override void Exit(){

	}

}
