using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkFly : ParentFly
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.movespeed = 0.5f;
        this.direction = Vector3.right;
    }
}
