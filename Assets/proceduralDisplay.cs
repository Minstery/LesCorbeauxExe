/*
*
* ATTACH THIS SCRIPT TO AN EMPTY GAMEOBJECT WHICH HAS TO BE IN THE MIDDLE OF THE SCENE OR IT WON'T WORK !!!!!!!!!!
*
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proceduralDisplay : MonoBehaviour {
  public GameObject[] tiles; // Put prefabs on this game object. Don't put the prefabs on the scene, just on the assets window. Each prefab=1 level design
  public GameObject[] tilesLevel2; // Put prefabs on this game object. Don't put the prefabs on the scene, just on the assets window. Each prefab=1 level design
  private float sizeTile = 20f;//Size of a level design. Be careful, it's private so if 960 pixel is not good, change it here ! And /100 the. actual size (ex : 1920px=19.2f)

    
    void Start() {

    shuffleTiles(tiles); //shuffle the order of the tiles
    shuffleTiles(tilesLevel2); //shuffle the order of the tiles
    for (int i = 0; i < tiles.Length + tilesLevel2.Length + 1; i++)
    {
      Debug.Log(i);
      if (i < 5)
        GameObject.Instantiate(tiles[i], new Vector3(transform.position.x, transform.position.y, 4) + i * (Vector3.right * sizeTile), Quaternion.identity);
      if (i > 5)
        GameObject.Instantiate(tilesLevel2[i - tiles.Length - 1], new Vector3(transform.position.x, transform.position.y, 4) + i * (Vector3.right * sizeTile), Quaternion.identity);
    }

        /*
        //same here, to have the same tiles shuffled in a different order and to add it after the tiles you instanciated before !
        shuffleTiles(tiles);
        for (int i = 0; i < tiles.Length; i++) {
            GameObject.Instantiate(tiles[i], transform.position + (i+tiles.Length)* (Vector3.right * sizeTile), Quaternion.identity);
        }
        */
        //If you want to do some other loops, you have to copy/paste and modify the (i+tiles.Length) to (i+(tiles.Length*2)), or *3,*4, etc... according to how many repetitions you want
    }

    //Function to shuffle the tiles array                 
    void shuffleTiles(GameObject[] tiles) {
        for (int t = 0; t < tiles.Length; t++) {
            GameObject tmp = tiles[t];
            int r = Random.Range(t, tiles.Length);
            tiles[t] = tiles[r];
            tiles[r] = tmp;
        }
    }

}