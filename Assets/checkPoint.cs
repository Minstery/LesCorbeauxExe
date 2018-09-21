using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour {

  public Player player;
  public GameObject deathMessage1;
  public droite droite;

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
    droite.enabled = false;
    player.enabled = false;
    yield return new WaitForSeconds(1);
    player.gameObject.SetActive(false);
    deathMessage1.SetActive(true);
    yield return new WaitForSeconds(2);
    yield return new WaitUntil(() => Input.GetButtonDown("Jump"));
    deathMessage1.SetActive(false);
    player.gameObject.SetActive(true);
    if (transform.position.x < 83)
    {
      transform.position = new Vector3(-25, 0, 0);
      player.transform.localPosition = new Vector3(-7, 0, 2);
    }
    else
    {
      transform.position = new Vector3(90, 0, 0);
      player.transform.localPosition = new Vector3(-7, 0, 2);
    }
    player.enabled = true;
    droite.enabled = true;
  }
}
