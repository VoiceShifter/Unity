using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouse : MonoBehaviour
{

      public float MouseSensetivity = 300f ;
      public Transform Player;

      float RotationX = 0f;

      // Start is called before the first frame update
      void Start()
      {
            Cursor.lockState = CursorLockMode.Locked;
      }

      // Update is called once per frame
      void Update()
      {
            float MouseX =  Input.GetAxis("Mouse X") * MouseSensetivity * Time.deltaTime;

            float MouseY = Input.GetAxis("Mouse Y") * MouseSensetivity * Time.deltaTime;

            RotationX -= MouseY;
            RotationX = Mathf.Clamp(RotationX, -90f, 90f);

            transform.localRotation = Quaternion.Euler(RotationX, 0f, 0f);
            Player.Rotate(Vector3.up * MouseX);


      }
}
