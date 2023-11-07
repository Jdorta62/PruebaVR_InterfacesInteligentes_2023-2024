using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate_RandomTeleport : MonoBehaviour {
  public delegate void IsNearEvent();
  public event IsNearEvent onNearBoard;
  public GameObject board;
  float distancePrefixed = 12;  
  public void Update() {
    float distance = Vector3.Distance(transform.position, board.transform.position);
    //Debug.Log("Distancia: " + distance);
    if (distance <= distancePrefixed) {
      onNearBoard?.Invoke();
    }
  }
}
