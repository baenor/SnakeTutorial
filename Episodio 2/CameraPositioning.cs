using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositioning : MonoBehaviour {

    public float z_offset;

	// Use this for initialization
	void Start () {
        float x = WallGeneration.mapGeneration.cols / 2f;
        float y = WallGeneration.mapGeneration.rows / 2f;

        transform.position = new Vector3(x, y, z_offset);
	}
	
}
