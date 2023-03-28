using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : ThanhMonoBehaviour
{
    [SerializeField] protected Transform model;
    public Transform Model { get => model; }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadModel();
    }

    private void LoadModel()
    {
        if (this.model != null) return;
        this.model = transform.Find("Model");
        Debug.Log(transform.name + ": loadModel", gameObject);
    }
}
