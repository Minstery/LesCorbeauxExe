using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonar : MonoBehaviour {

  public GameObject onde;
  public float cooldownTime;
  bool canShot = true;
	
	// Update is called once per frame
	void Update () {
    if (Input.GetKeyDown(KeyCode.Space) && canShot)
    {
      Instantiate(onde, transform.position + Vector3.right * 0.1f, Quaternion.Euler(new Vector3(0, 0, -90)));
      StartCoroutine(coolDown());
    }
	}

  IEnumerator coolDown()
  {
    canShot = false;
    yield return new WaitForSeconds(cooldownTime);
    canShot = true;
  }
}
