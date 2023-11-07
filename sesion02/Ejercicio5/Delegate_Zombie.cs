using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Parte 2 examen
public class Delegate_Zombie : MonoBehaviour {
  public delegate void CollisionEvent();
  public event CollisionEvent OnCollideChair;
  private void OnCollisionEnter(Collision other) {
    if (other.gameObject.tag == "Silla") {
      OnCollideChair?.Invoke();
    }
  }
}
