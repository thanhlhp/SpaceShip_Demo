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
    protected override void OnEnable()
    {
        base.OnEnable();
        this.GetDirection();
    }

    private void GetDirection()
    {
        Vector3 camPos = GameCtrl.Instance.MainCamera.transform.position;
        Vector3 objPos = transform.parent.position;
        camPos.x += Random.Range(-7, 7);
        camPos.z += Random.Range(-7, 7);
        Vector3 diff = camPos - objPos;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f,0f,rot_z);
    }
}
