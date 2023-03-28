using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRotate : JunkAbtract
{
    [SerializeField] protected float rotateSpeed = 9f;
    private void FixedUpdate()
    {
        this.Rotating();
    }

    private void Rotating()
    {
        Vector3 eulers = new Vector3(0, 0, 1);
        this.junkCtrl.Model.Rotate(eulers * this.rotateSpeed * Time.fixedDeltaTime);
    }
}
