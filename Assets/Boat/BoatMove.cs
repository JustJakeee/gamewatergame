using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BoatMove : MonoBehaviour
{
    [SerializeField]
    private Offset offset;
    public float restingHeight = 0;
    public InputAction input;
    private Vector2 moveDir = Vector2.zero;
    public float localMovespeed = 1;
    private Vector2 localOffset = Vector2.zero;
    private Vector2 vel = Vector2.zero;
    public float acceleration = 0.4f;

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        moveDir = input.ReadValue<Vector2>();
        vel = Vector2.SmoothDamp(vel, moveDir, ref vel, acceleration);
        localOffset += vel * localMovespeed * Time.deltaTime;
        Vector3 newPos = new Vector3(localOffset.x, transform.position.y, localOffset.y + offset.globalOffset);
        transform.position = newPos;
        transform.rotation = Quaternion.Euler(0, 180, 0);
        Quaternion rot = transform.rotation;
        rot.eulerAngles += new Vector3(0, vel.x * 20, vel.x * 10);
        transform.rotation = rot;

    }
}
