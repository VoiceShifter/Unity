using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
      public CharacterController Controller;
      public float Speed = 12f;


      public Vector3 Velocity;
      public float Gravity = -19.2f;
      public float JumpHeight = 2f;
      public Transform GroundCheck;
      public float GroudDistance = 0.4f;
      public LayerMask GroundMask;

      public bool IsGrounded;
      public bool IsMoving = false;

      // Start is called before the first frame update
      void Start()
      {
        
      }

      // Update is called once per frame
      void Update()
      {
            IsGrounded = Physics.CheckSphere(GroundCheck.position, GroudDistance, GroundMask);

            if (IsGrounded && Velocity.y < 0)
            {
                  Velocity.y = -2f;
            }
            float X = Input.GetAxis("Horizontal");
            float Z = Input.GetAxis("Vertical");

            Vector3 Movement = transform.right * X + transform.forward * Z;
            Controller.Move(Movement * Speed * Time.deltaTime);
            if (Input.GetButtonDown("Jump") && IsGrounded)
            {
                  Velocity.y = Mathf.Sqrt(JumpHeight * -2f * Gravity);
                  
            }

            if (X == 0 && Z == 0)
            {
                  IsMoving = false;
            }
            else
            {
                  IsMoving = true;
            }

            Velocity.y += Gravity * Time.deltaTime;

            Controller.Move(Velocity * Time.deltaTime );
      }
}
