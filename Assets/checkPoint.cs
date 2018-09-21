using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour {

  public Player player;
  public GameObject deathMessage1;

  // Update is called once per frame
  void Update () {
    if(player.dead == true)
    {
      player.dead = false;
      StartCoroutine(waitForMessage());
    }
  }

  IEnumerator waitForMessage()
  {
    player.gameObject.SetActive(false);
    deathMessage1.SetActive(true);
    yield return new WaitForSeconds(2);
    deathMessage1.SetActive(false);
    player.gameObject.SetActive(true);
    if (transform.position.x < 110)
    {
      transform.position = new Vector3(0, 0, 0);
      player.transform.localPosition = new Vector3(-7, 0, 2);
    }
    else
    {
      transform.position = new Vector3(110, 0, 0);
      player.transform.localPosition = new Vector3(-7, 0, 2);
    }
  }
}
