using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanete : MonoBehaviour
{
    [SerializeField] float speed = 8;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
