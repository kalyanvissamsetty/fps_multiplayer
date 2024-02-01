using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3.5f, rotateSpeed = 100f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;

        rb.MovePosition(rb.position + speed * Input.GetAxis("Vertical") * Time.deltaTime * transform.forward + speed * Input.GetAxis("Horizontal") * Time.deltaTime * transform.right);
        Vector3 rotateY = new Vector3(0, Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime, 0);
        if (movement!=Vector3.zero)
            rb.MoveRotation(rb.rotation * Quaternion.Euler(rotateY));
    }

}
