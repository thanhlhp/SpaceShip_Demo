using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentFly : ThanhMonoBehaviour
{
  
        // Start is called before the first frame update
        [SerializeField] protected float movespeed = 1f;
        [SerializeField] protected Vector3 direction;
        private void Update()
        {
            transform.parent.Translate(direction * movespeed * Time.deltaTime);
        }
    
    
}
