using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winOrLose : MonoBehaviour {

  public GameObject win;

  void Update()
  {
    if (transform.position.x > 210)
    {
      win.SetActive(true);
      Destroy(this);
    }
  }
}
