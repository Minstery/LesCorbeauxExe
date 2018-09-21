using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomCreator : MonoBehaviour {

  public List<GameObject> listGo = new List<GameObject>();
  public GameObject lastRoom;
  public float lastRoomX;
  public Camera cam;
  public Player player;
  public float lastRoomDistance;

	// Use this for initialization
	void Start () {
    listGo[0].transform.position = new Vector3(cam.transform.position.y + lastRoomDistance / 2, cam.transform.position.y, 2);
    lastRoom = listGo[0];
  }

  // Update is called once per frame
  void Update () {
    if (player.transform.position.x > lastRoom.transform.position.x)
    {
      if (lastRoom == listGo[0])
      {
        listGo[1].transform.position = new Vector3(lastRoom.transform.position.x + lastRoomDistance, cam.transform.position.y, 2);
        lastRoom = listGo[1];
      }
      if (lastRoom == listGo[1])
      {
        listGo[0].transform.position = new Vector3(lastRoom.transform.position.x + lastRoomDistance, cam.transform.position.y, 2);
        lastRoom = listGo[0];
      }
    }
  }
}
