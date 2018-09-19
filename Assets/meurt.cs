using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meurt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

  // Update is called once per frame
  void OnCollisionEnter2D(Collision2D coll)
  {
    Destroy(gameObject);
  }
}
