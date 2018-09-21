using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public float speed;
  public bool dead;
  // Use this for initialization
  void Update()
  {
    transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);
  }

  void onTriggerEnter2D(Collider2D col)
  {
    col.GetComponent<SpriteRenderer>().color = Color.white;
  }

}
