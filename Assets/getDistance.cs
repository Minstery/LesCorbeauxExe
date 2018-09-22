using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getDistance : MonoBehaviour {

  public Player Player;
  Vector3 startPos;
  public Text distance;

  // Use this for initialization
  void Start () {
    startPos = Player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
    distance.text = "Distance : " + (int)Vector3.Distance(startPos, Player.transform.position) + "m";
	}
}
