using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droite : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.right * 0.03f;
	}
}
