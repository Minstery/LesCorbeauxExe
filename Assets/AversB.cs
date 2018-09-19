using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AversB : MonoBehaviour
{

  public Vector2 Offset;
  Vector3 startPos;
  public bool towardStartPos;
  public float slowness;

  private void Start()
  {
    startPos = transform.position;
  }

  // Update is called once per frame
  void Update()
  {
    if (!towardStartPos)
    {
      transform.position += new Vector3(Offset.x / slowness, Offset.y / slowness, 0);
      if(Vector3.Distance(transform.position, new Vector3(startPos.x + Offset.x, startPos.y + Offset.y, transform.position.z)) < 0.1f){
        towardStartPos = true;
      }
    }
    if (towardStartPos)
    {
      transform.position += new Vector3(-Offset.x / slowness, -Offset.y / slowness, 0);
      if (Vector3.Distance(transform.position, startPos) < 0.1f)
      {
        towardStartPos = false;
      }

    }
  }
}
