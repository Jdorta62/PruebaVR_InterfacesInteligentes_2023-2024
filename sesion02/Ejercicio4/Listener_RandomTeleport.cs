using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener_RandomTeleport : MonoBehaviour {
  public Delegate_RandomTeleport teleportEvent;
  public float chairDistance = 2;
  public GameObject zombie;
  void Start() {
    teleportEvent.onNearBoard += OnNearBoard;
  }
  private void OnNearBoard() {
    if (gameObject.tag == "Maceta") {
      transform.position = new Vector3(Random.Range(-10f, 10f), transform.position.y, Random.Range(0f, 10f));
    }
    if (gameObject.tag == "Silla") {
      //transform.position = new Vector3(zombie.position.x - chairDistance, zombie.position.y, zombie.position.z - chairDistance);
      //transform.position = Vector3.MoveTowards(transform.position, zombie.transform.position, chairDistance);
      // Parte 2 examen
      Vector3 direction = (zombie.transform.position - transform.position).normalized;
      Vector3 newPosition = transform.position + direction * chairDistance;
      transform.position = newPosition;
      //Debug.Log(newPosition);
    }
  }

}
