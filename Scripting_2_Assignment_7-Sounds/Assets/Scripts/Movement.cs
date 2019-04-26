using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontal;
    public float vertical;

    public float speed;

    public Vector3 direction;
    public Vector3 normalyzedDirection;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        direction = new Vector3(horizontal, 0, vertical).normalized;

        normalyzedDirection = direction.normalized;

        Vector3 desiredMovement = normalyzedDirection * speed * Time.deltaTime;

        gameObject.transform.Translate(direction * speed * Time.deltaTime);

    }
}

