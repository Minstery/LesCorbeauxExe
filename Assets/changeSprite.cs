using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSprite : MonoBehaviour {

  public GameObject lastSprite;
  public GameObject nextSprite;
  public AudioClip hell;
  public AudioSource audioSource;
  bool newSound;

  // Use this for initialization
  void Start () {
		
	}

  // Update is called once per frame
  void Update()
  {
    if (transform.position.x > 90)
    {
      lastSprite.SetActive(false);
      nextSprite.SetActive(true);
      Destroy(this);
      if (!newSound)
      {
        audioSource.Stop();
        audioSource.clip = hell;
        audioSource.Play();
        newSound = true;
      }
    }
  }
}
