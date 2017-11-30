using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ステートを持つオブジェクトの基底クラス
public abstract class StateObjectBase<T, TEnum> : MonoBehaviour
    where T : class where TEnum : System.IConvertible
{
    //ステートの
    protected List<State<T>> stateList = new List<State<T>>();

    //ステートの管理用クラス
    protected StateMachine<T> stateMachine;

    //初期化処理
    protected virtual void Start()
    {

	}

	//更新
	protected virtual void Update()
	{
		if (stateMachine != null)
			stateMachine.Update();
	}

	//ステートの切り替え
	public virtual void ChangeState(TEnum state)
    {
        if (stateMachine == null)
        {
            return;
        }

        stateMachine.ChangeState(stateList[state.ToInt32(null)]);
    }


    //現在のステートと一致していたらtrueを返す
    public virtual bool IsCurrentState(TEnum state)
    {
        if (stateMachine == null)
        {
            return false;
        }

        return stateMachine.CurrentState == stateList[state.ToInt32(null)];
    }
}