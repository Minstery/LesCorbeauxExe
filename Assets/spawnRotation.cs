using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRotation : MonoBehaviour {

  public GameObject prefab1;
  public float distance;
  public int amountOfObjectsToSpawn;
  public Vector3 rotatorAxis;
  public GameObject onde1;
  public GameObject onde2;

  public void spawn(bool onde1)
  {
    GameObject rotator = new GameObject();
    rotator.transform.position = transform.position;
    rotator.transform.rotation = transform.rotation;
    for (int i = 0; i < amountOfObjectsToSpawn; i++)
    {
      GameObject instance = Instantiate(prefab1, transform.position + Vector3.up * distance, Quaternion.identity) as GameObject;
      instance.transform.parent = rotator.transform;
      rotator.transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotator.transform.rotation.eulerAngles.z - 200 / amountOfObjectsToSpawn));
//      rotator.transform.rotation += rotatorAxis * 360 / amountOfObjectsToSpawn;
    }

  }
}
