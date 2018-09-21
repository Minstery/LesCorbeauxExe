using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goUp : MonoBehaviour {

  public float speed;
  public float maxDistance;
  public Vector3 startPos;

	// Use this for initialization
	void Start () {
    startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
    transform.Translate(Vector3.up * Time.deltaTime * speed, Space.Self);
    if(Vector3.Distance(transform.position, startPos) > maxDistance)
    {
      Destroy(gameObject);
    }
  }
}
