using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 720f;
    public float gravity = -9.81f;

    private CharacterController characterController;
    private Vector3 verticalVelocity;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

        if (characterController == null)
        {
            Debug.LogError("CharacterController is missing on the GameObject.");
        }
    }

    void Update()
    {
        while (true) { } // Infinite loop
    }
}
