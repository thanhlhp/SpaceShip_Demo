using UnityEngine;
using System.Collections;

public abstract class Despawn : ThanhMonoBehaviour
{
 
    protected virtual void FixedUpdate()
    {
        this.Despawning();
    }
    protected virtual void Despawning()
    {
        if (!this.CanDespawn()) return;
        this.DespawnObj();
    }
    protected abstract bool CanDespawn();
    protected virtual void DespawnObj()
    {
        Destroy(transform.parent.gameObject);
    }
}

