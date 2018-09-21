using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AversB : MonoBehaviour
{

  public Vector2 Offset;
  Vector3 startPos;
  public bool towardStartPos;
  public float slowness;
  public SpriteRenderer SpriteRenderer;

  private void Start()
  {
    SpriteRenderer = GetComponent<SpriteRenderer>();
    startPos = transform.localPosition;
    if(Offset.x > 0)
    {
      SpriteRenderer.flipX = !SpriteRenderer.flipX;
    }
  }

  // Update is called once per frame
  void Update()
  {
    if (!towardStartPos)
    {
      transform.localPosition += new Vector3(Offset.x / slowness, Offset.y / slowness, 0);
      if(Vector3.Distance(transform.localPosition, new Vector3(startPos.x + Offset.x, startPos.y + Offset.y, transform.localPosition.z)) < 0.1f){
        towardStartPos = true;
        SpriteRenderer.flipX = !SpriteRenderer.flipX;
      }
    }
    if (towardStartPos)
    {
      transform.localPosition += new Vector3(-Offset.x / slowness, -Offset.y / slowness, 0);
      if (Vector3.Distance(transform.localPosition, startPos) < 0.1f)
      {
        towardStartPos = false;
        SpriteRenderer.flipX = !SpriteRenderer.flipX;
      }

    }
  }
}
