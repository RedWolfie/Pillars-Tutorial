using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
  override public void Move() // POLYMORPHISM
  {
    transform.Translate(Speed * Vector3.back * Time.deltaTime); // INHERITANCE (Speed from parent)
  }
}
