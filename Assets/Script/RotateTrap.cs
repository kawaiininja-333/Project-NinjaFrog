using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotateTrap : MonoBehaviour
{
    [SerializeField] private Vector3 rotationAxis = Vector3.forward;
    [SerializeField] private float rotationSpeed = 1000f;
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);


    }
}
