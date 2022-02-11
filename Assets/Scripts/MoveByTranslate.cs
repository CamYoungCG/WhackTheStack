using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class MoveByTranslate : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed;
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey("a"))
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        if (Input.GetKey("w"))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (Input.GetKey("s"))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        if (Input.GetKey("x"))
            transform.Translate(Vector3.up * (moveSpeed/2) * Time.deltaTime);
        if (Input.GetKey("z"))
            transform.Translate(Vector3.down * (moveSpeed/2) * Time.deltaTime);
        if (Input.GetKey("e"))
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        if (Input.GetKey("q"))
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
    }
}