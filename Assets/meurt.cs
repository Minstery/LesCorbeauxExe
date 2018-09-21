using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meurt : MonoBehaviour {

  public AudioSource AudioSource;

	// Use this for initialization
	void Start () {
		
	}

  // Update is called once per frame
  void OnCollisionEnter2D(Collision2D coll)
  {
    AudioSource.Play();
    GetComponent<Player>().dead = true;
    coll.gameObject.GetComponent<eventLight>().lightShown();
  }
}
