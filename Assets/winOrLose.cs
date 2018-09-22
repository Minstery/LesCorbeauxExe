using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winOrLose : MonoBehaviour {

  public GameObject win;
  public GameObject win2;

  void Update()
  {
    if (transform.position.x > 210)
    {
      StartCoroutine("endCredits");
      this.enabled = false;
    }
  }

  IEnumerator endCredits()
  {
    win.SetActive(true);
    yield return new WaitUntil(() => Input.GetButtonDown("Jump"));
    win.SetActive(false);
    win2.SetActive(true);
    yield return new WaitUntil(() => Input.GetButtonDown("Jump"));
    Application.Quit();
    Destroy(this);
  }
}
