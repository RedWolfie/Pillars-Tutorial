using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
  override public void Move() // POLYMORPHISM
  {
    transform.Translate(Speed * Vector3.up * Time.deltaTime); // INHERITANCE (Speed from parent)
  }
}
