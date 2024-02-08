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
        localOffset += moveDir * localMovespeed * Time.deltaTime;
        Vector3 newPos = new Vector3(localOffset.x, restingHeight, localOffset.y + offset.globalOffset);
        transform.position = newPos;
        transform.rotation = Quaternion.identity;
    }
}
