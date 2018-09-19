using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

  // Update is called once per frame
  void OnTriggerExit2D(Collider2D col)
  {
    if(col.tag == "Player")
    {
      Destroy(col.gameObject);
    }
  }
}
