using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRandom : ThanhMonoBehaviour
{
    [SerializeField] protected JunkCtrl junkCtrl;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadJunkCtrl();
    }

    private void LoadJunkCtrl()
    {
        if (junkCtrl != null) return;
        this.junkCtrl = this.GetComponent<JunkCtrl>();
    }
    private void Start()
    {
        this.JunkSpawning();
    }

    private void JunkSpawning()
    {
        Vector3 pos = transform.position;
        Quaternion ros = transform.rotation;
        Transform obj = this.junkCtrl.JunkSpawner.Spawn(JunkSpawner.Junk1, pos, ros);
        obj.gameObject.SetActive(true);
        Invoke(nameof(this.JunkSpawning), 2f);
    }
}
