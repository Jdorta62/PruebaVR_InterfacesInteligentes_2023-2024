using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {
  public Vector3 moveDirection;
  public float speed;
  // Start is called before the first frame update
  void Start() {
      
  }  
  // Update is called once per frame
  void Update() {   
    float horizontalMovement = Input.GetAxis("Horizontal");
    float verticalMovement = Input.GetAxis("Vertical");
    moveDirection = new Vector3(horizontalMovement * speed * 0.1f, 0, verticalMovement * speed * 0.1f);
    transform.Translate(moveDirection);
  }
}
