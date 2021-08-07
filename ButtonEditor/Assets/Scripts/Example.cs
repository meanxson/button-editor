using System.Collections;
using System.Collections.Generic;
using Plugins;
using UnityEngine;

public class Example : MonoBehaviour
{
   [EditorButton()]
   public void FooAndMoreFoo()
   {
      Debug.Log("Hello");
   }
}
