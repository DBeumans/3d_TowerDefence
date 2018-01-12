using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy {

    public virtual void Enter()
    {
    }

    public virtual void Exit()
    {
    }

    public abstract void Act();
    public abstract void Reason();

}
