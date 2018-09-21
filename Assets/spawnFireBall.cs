using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFireBall : MonoBehaviour {

  public GameObject go;

	// Use this for initialization
	void Start () {
    StartCoroutine(spawnBall());
    GameObject instance = Instantiate(go, new Vector3(transform.position.x, -3, transform.position.z), transform.rotation) as GameObject;
  }

  IEnumerator spawnBall()
  {
    yield return new WaitForSeconds(4);
    GameObject instance = Instantiate(go, new Vector3(transform.position.x, -3, transform.position.z) , transform.rotation) as GameObject;
    StartCoroutine(spawnBall());
  }

}
