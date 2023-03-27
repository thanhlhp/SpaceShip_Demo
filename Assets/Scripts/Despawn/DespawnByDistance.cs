using UnityEngine;
using System.Collections;

public class DespawnByDistance : Despawn
{
    [SerializeField] protected float distanceLimit = 50f;
    [SerializeField] protected float distance = 0;
    [SerializeField] protected Camera mainCamera;
    protected override void LoadComponent()
    {
        this.loadCamera();
    }
    protected virtual void loadCamera()
    {
        if (this.mainCamera != null) return;
        this.mainCamera = Transform.FindObjectOfType<Camera>();

    }
    protected override bool CanDespawn()
    {
        this.distance = Vector3.Distance(this.transform.position, mainCamera.transform.position);
        if (this.distance >= this.distanceLimit)
        {
            return true;
        }
        return false;
    }
   
}

