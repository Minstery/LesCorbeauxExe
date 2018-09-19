using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplace : MonoBehaviour {

  public float speed;
	
	// Update is called once per frame
	void Update () {
    transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);
	}
  
}
