using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance; }
    [SerializeField] protected Vector3 mouseWorldPos;
    public Vector3 MouseWorldPos { get => mouseWorldPos; }
    [SerializeField] protected float onFiring;
    public float OnFiring { get => onFiring; }
    // Start is called before the first frame update
    private void Awake()
    {
        if (InputManager.instance != null) Debug.LogError("Only 1 InputManager exist");
        InputManager.instance = this;
    }
    void Update()
    {
        this.GetMouseDown();
    }
    void FixedUpdate()
    {
        this.GetMousePos();
    }
    protected virtual void GetMousePos()
    {
        mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    protected virtual void GetMouseDown()
    {
        this.onFiring = Input.GetAxis("Fire1");
    }
}
