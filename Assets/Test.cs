using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

    

public class Test : MonoBehaviour
{
      private static readonly System.Random aRandom = new System.Random();
      public GameObject TestObject;

      private float AsisX = 0;
      int Case;
      // Start is called before the first frame update
      void Start()
      {
            Debug.Log(AsisX);
            Thread TestThread = new Thread(Move);
            TestThread.Start();

      }

      private void Move()
      {
            for(;;)
            {
                 
                  AsisX = aRandom.Next(1, 10); //Write random generator
                  Case = aRandom.Next(1, 3);
                  switch(Case)
                  {
                        case 1:
                              transform.position = new Vector3(AsisX, 0, 0);
                              Thread.Sleep(500);
                              break;
                        case 2:
                              transform.position = new Vector3(0, AsisX, 0);
                              Thread.Sleep(500);
                              break;
                        case 3: 
                              transform.position = new Vector3(0, 0, AsisX);
                              Thread.Sleep(500);
                              break;
                        default:
                              break;

                  }
            }
      }
      // Update is called once per frame
      void Update()
      {
            
            
      }
}
