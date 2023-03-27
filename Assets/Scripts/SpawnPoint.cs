using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnPoint : ThanhMonoBehaviour
{
    [SerializeField] protected List<Transform> points;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadPoints();
    }

    protected virtual void LoadPoints()
    {
        if (this.points.Count > 0) return;
        foreach(Transform point in transform)
        {
            this.points.Add(point);
        }
    }
    public virtual Transform GetRandom()
    {
        int rand = Random.Range(0, points.Count);
        return this.points[rand];
    }

}
