using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Illumine : MonoBehaviour {
  public DynamicLight2D.DynamicLight light2d_instance;

  void OnEnable()
  {
    light2d_instance.OnEnterFieldOfView += onEnter;
    light2d_instance.OnExitFieldOfView += onExit;
    light2d_instance.InsideFieldOfViewEvent += onInside;
  }

  void OnDisable()
  {
    light2d_instance.OnEnterFieldOfView -= onEnter;
    light2d_instance.OnExitFieldOfView -= onExit;
    light2d_instance.InsideFieldOfViewEvent -= onInside;
  }


  // Use this for initialization
  void onEnter(GameObject caster, DynamicLight2D.DynamicLight light)
  {
    Debug.Log("OnEnter: " + caster.name);
    Debug.Log("OnEnter: " + light.name);
  }

  void onExit(GameObject caster, DynamicLight2D.DynamicLight light)
  {
    Debug.Log("OnExit: " + caster.name);
    Debug.Log("OnExit: " + light.name);
  }

  void onInside(GameObject[] arrayOfCasters, DynamicLight2D.DynamicLight light)
  {
    foreach (GameObject _go in arrayOfCasters)
      Debug.Log("OnExit: " + _go.name);
  }
}
