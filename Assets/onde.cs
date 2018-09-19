using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onde : MonoBehaviour {
  DynamicLight2D.DynamicLight light2d_instance;

  // Use this for initialization
  void Start () {
    light2d_instance = GetComponent<DynamicLight2D.DynamicLight>();

  }
	
	// Update is called once per frame
	void Update () {
    light2d_instance.LightRadius += 0.3f; 
    if(light2d_instance.LightRadius > 11)
    {
      Destroy(gameObject);
    }
  }
}
