using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getListeners : MonoBehaviour {

  public DynamicLight2D.DynamicLight light2d_instance;

  void OnEnable()
  {
    light2d_instance = GetComponent<DynamicLight2D.DynamicLight>();
    GameObject go = GameObject.Find("LightableObject");
    foreach (SightListener item in go.GetComponentsInChildren<SightListener>())
    {
      light2d_instance.DDLEvent_InsideFOV.AddListener(item.myListener_onEnter);
    }
  }
}
