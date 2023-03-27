using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : ThanhMonoBehaviour
{
    [SerializeField] protected JunkSpawner junkSpawner;
    public  JunkSpawner JunkSpawner { get => junkSpawner; }
    [SerializeField] protected JunkSpawnPoint junkSpawnPoint;
    public JunkSpawnPoint JunkSpawnPoint { get => junkSpawnPoint; }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadJunkSpawner();
        this.LoadJunkSpawnPoint();
    }

    private void LoadJunkSpawnPoint()
    {
        if (this.junkSpawnPoint != null) return;
        this.junkSpawnPoint = this.GetComponent<JunkSpawnPoint>();
    }

    private void LoadJunkSpawner()
    {
        if (this.junkSpawner != null) return;
        this.junkSpawner = this.GetComponent<JunkSpawner>();
    }
}
