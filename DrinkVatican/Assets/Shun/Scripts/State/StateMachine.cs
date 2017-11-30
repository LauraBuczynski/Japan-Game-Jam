using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ステート管理用クラス
public class StateMachine<T>
{
    //実行中のステート
    private State<T> m_currentState;

    public StateMachine()
    {
        m_currentState = null;
    }

    public State<T> CurrentState
    {
        get { return m_currentState; }
    }


    //ステートの切り替え
    public void ChangeState(State<T> state)
    {
        //終了処理
        if (m_currentState != null)
        {
            m_currentState.Exit();
        }

        //ステート切替
        m_currentState = state;

        //開始処理
        m_currentState.Enter();
    }

    //ステートの実行
    public void Update()
    {
        if (m_currentState != null)
        {
            m_currentState.Execute();
        }
    }
}