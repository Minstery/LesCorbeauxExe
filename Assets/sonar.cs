using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonar : MonoBehaviour {

  public GameObject onde;
  public GameObject ondeLive;
  public float cooldownTime;
  bool canShot = true;
  public ondeList ondeList;
  public spawnRotation spawnRotation;
  public GameObject ondePrefab;
  public bool onde1;

  private void Start()
  {
/*    ondeLive.transform.position = transform.position + Vector3.right;
    ondeLive.SetActive(true);
    StartCoroutine(coolDown());
    ondeList.Add(ondeLive);*/
  }

  // Update is called once per frame
  void Update () {
    if (Input.GetButton("Jump") && canShot)
    {
      //GameObject go = Instantiate(onde, transform.position + Vector3.right * 0.1f, Quaternion.Euler(new Vector3(0, 0, -90)));
      GameObject go = Instantiate(ondePrefab, transform.position + Vector3.right * 0.1f, Quaternion.Euler(new Vector3(0, 0, -200)));
      StartCoroutine(coolDown());
      //ondeList.Add(go);
    }
  }

  IEnumerator coolDown()
  {
    
/*    spawnRotation.transform.position = transform.position += Vector3.right * 0.1f;
    spawnRotation.spawn(onde1);
    onde1 = !onde1;
*/
    canShot = false;
    /*    yield return new WaitForEndOfFrame();
        ondeLive.SetActive(true);
        ondeLive.transform.position = transform.position + Vector3.right;*/
    yield return new WaitForSeconds(cooldownTime);
    canShot = true;
  }

  private void OnDisable()
  {
    StopAllCoroutines();
    canShot = true;
  }
}
