using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : ThanhMonoBehaviour
{
    private static GameCtrl instance;
    public static GameCtrl Instance { get => instance; }
    [SerializeField] protected Camera mainCamera;
    public Camera MainCamera { get => mainCamera; }
    protected override void Awake()
    {
        base.Awake();
        if (GameCtrl.instance != null) Debug.LogError("Only 1 GameCtrl exist");
        GameCtrl.instance = this;
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadCamera();

    }

    private void LoadCamera()
    {
        if (this.mainCamera != null) return;
        this.mainCamera = GameCtrl.FindObjectOfType<Camera>();
    }
}


