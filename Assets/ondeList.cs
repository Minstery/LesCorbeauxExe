using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ondeList : MonoBehaviour {
  public List<GameObject> listListener = new List<GameObject>();

  // Use this for initialization
  public void Add (GameObject light2D) {
    listListener.Add(light2D);
    foreach (eventLight eventLight in FindObjectsOfType<eventLight>())
    {
      eventLight.addLocalListener(light2D.GetComponent<DynamicLight2D.DynamicLight>());
    }
	}
	
	// Update is called once per frame
	void LateUpdate () {
    for (int i = 0; i < listListener.Count; i++)
    {
      if (listListener[i] == null)
        listListener.Remove(listListener[i]);
    }
	}
}
