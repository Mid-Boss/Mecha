using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {

    public GameObject tilePrefab;
    public int numberOfTiles = 10;
    public float distanceBetweenTiles = 1000f;

	// Use this for initialization
	void Start () {
        CreateTiles();
	}
	
	// Update is called once per frame
	void CreateTiles()
    {
        float xOffset = 0f;
        for (int tilesCreated = 0; tilesCreated < numberOfTiles; tilesCreated += 1)
        {
            xOffset += distanceBetweenTiles;
            Vector3 pos = new Vector3(transform.position.x + xOffset, transform.position.y, transform.position.z);
            Instantiate(tilePrefab, pos, transform.rotation);
        }
    }
}
