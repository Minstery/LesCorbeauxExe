using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSprite : MonoBehaviour {

  public GameObject lastSprite;
  public GameObject nextSprite;

  // Use this for initialization
  void Start () {
		
	}

  // Update is called once per frame
  void Update()
  {
    if (transform.position.x > 100)
    {
      lastSprite.SetActive(false);
      nextSprite.SetActive(true);
      Destroy(this);
    }
  }
}
