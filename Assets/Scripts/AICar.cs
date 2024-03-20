using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICar : MonoBehaviour
{

    [SerializeField] private GameObject car;
    [SerializeField] private float speed = 20f;

    void FixedUpdate()
    {
        car.transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
