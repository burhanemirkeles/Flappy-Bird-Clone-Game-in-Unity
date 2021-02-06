using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 3f;

    private void Start()
    {
        Destroy(gameObject, 4f);
    }
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
