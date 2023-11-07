using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_Teleport : MonoBehaviour {
    public Transform target;

    void Update() {
      if (Input.GetKeyDown(KeyCode.T)) {
        transform.position = target.position;
      }
    }
}