using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
      Animator fAnimator;

      // Start is called before the first frame update
      void Start()
      {
              fAnimator = GetComponent<Animator>();
      }

      // Update is called once per frame
      void Update()
      {
            if (Input.GetKeyDown(KeyCode.E)) 
            { 
                  fAnimator.SetTrigger("JumpTrigger");
            }
      }
}
