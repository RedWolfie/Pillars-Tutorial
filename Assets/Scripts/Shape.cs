using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
  protected float Speed { get; set; } // ENCAPSULATION
  // Start is called before the first frame update
  void Start()
  {
    Speed = 5.0f;
  }

  // Update is called once per frame
  void Update()
  {
    Move(); // ABSTRACTION
  }

  virtual public void  Move()
  {
    transform.Translate(Speed * Vector3.forward * Time.deltaTime);
  }
}
