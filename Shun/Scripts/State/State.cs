using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State<T> {

    // このステートを利用するインスタンス
    protected T obj;

    public State(T obj)
    {
        this.obj = obj;
    }

    // このステートに遷移する時に一度だけ呼ばれる
    public virtual void Enter() { }

    // このステートである間、毎フレーム呼ばれる
    public virtual void Execute() { }

    // このステートから他のステートに遷移するときに一度だけ呼ばれる
    public virtual void Exit() { }
}
