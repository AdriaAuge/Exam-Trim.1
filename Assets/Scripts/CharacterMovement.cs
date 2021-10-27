using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float speed;

    public CharacterController player;

    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        player.Move(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);
    }
}

