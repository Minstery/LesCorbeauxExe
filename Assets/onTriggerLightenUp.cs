using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTriggerLightenUp : MonoBehaviour {

  // Update is called once per frame
  void OnTriggerEnter2D(Collider2D col)
  {
    eventLight eventLight = col.GetComponent<eventLight>();
    if (eventLight)
    {
      eventLight.lightShown();
      Destroy(gameObject);
    }
  }
}
