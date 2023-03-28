using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRandom : ThanhMonoBehaviour
{
    [SerializeField] protected JunkSpawnerCtrl junkSpawnerCtrl;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadJunkCtrl();
    }

    private void LoadJunkCtrl()
    {
        if (junkSpawnerCtrl != null) return;
        this.junkSpawnerCtrl = this.GetComponent<JunkSpawnerCtrl>();
    }
    private void Start()
    {
        this.JunkSpawning();
    }

    private void JunkSpawning()
    {
        Transform ranPoint = this.junkSpawnerCtrl.JunkSpawnPoint.GetRandom();
        Vector3 pos = ranPoint.position;
        Quaternion ros = ranPoint.rotation;
        Transform obj = this.junkSpawnerCtrl.JunkSpawner.Spawn(JunkSpawner.Junk1, pos, ros);
        obj.gameObject.SetActive(true);
        Invoke(nameof(this.JunkSpawning), 1f);
    }
}
