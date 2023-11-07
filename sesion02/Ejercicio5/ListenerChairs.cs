using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Parte 2 examen
public class ListenerChairs : MonoBehaviour {
  public Delegate_Zombie eventChairCollision;
  public GameObject[] spiders;
  public float spiderSpeed;
  public GameObject zombie;
  private bool moveSpiders = false;
  void Start() {
    eventChairCollision.OnCollideChair += OnCollideChair;
  }

  void Update() {
    if (moveSpiders == true) {
      MoveSpiders();
    }
  }

  private void OnCollideChair() {
    if (gameObject.tag == "Silla") {
      moveSpiders = true;
    }
  }
  private void MoveSpiders() {
    foreach (var spider in spiders) {
      Vector3 direction = (zombie.transform.position - spider.transform.position).normalized;
      Vector3 newPosition = spider.transform.position + direction * spiderSpeed;
      spider.transform.position = newPosition;
    }
  }
}
