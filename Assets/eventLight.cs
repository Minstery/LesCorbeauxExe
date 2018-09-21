using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventLight : MonoBehaviour {

  public bool wait;

  private void Start()
  {
    GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0f);
  }

  IEnumerator yesEvent()
  {
    wait = true;
    yield return new WaitForSeconds(1);
    wait = false;
  }

  public void addLocalListener(DynamicLight2D.DynamicLight light2d)
  {
    light2d.OnEnterFieldOfView += onEnter;
    StartCoroutine(yesEvent());
  }


  void onEnter(GameObject g, DynamicLight2D.DynamicLight light)
  {

    if (gameObject.GetInstanceID() == g.GetInstanceID())
    {
      GetComponent<SpriteRenderer>().color = Color.white;
    }

  }

  IEnumerator waitAndLit()
  {
    yield return new WaitForSeconds(1.5f);
    GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0f);
  }

  public void lightShown()
  {
    GetComponent<SpriteRenderer>().color = Color.white;
    StopAllCoroutines();
    StartCoroutine(waitAndLit());
  }
}
