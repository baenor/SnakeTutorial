using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class WallGeneration : MonoBehaviour {

    //Singleton

    public static WallGeneration mapGeneration;


    public int rows;
    public int cols;

    Transform tidyParent;

    void Awake()
    {
        mapGeneration = this;
    }

	// Use this for initialization
	void Start () {
        tidyParent = GameObject.Find("TidyParent").transform;
	}
	
	// Update is called once per frame
	void Update () {
        if(!Application.isPlaying)
            GenerateWalls();
    }

    void GenerateWalls()
    {
        if(tidyParent != null)
        {
            DestroyImmediate(tidyParent.gameObject);
        }
        tidyParent = new GameObject("TidyParent").transform;

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(i == 0 || i == rows - 1)
                {
                    Instantiate(Resources.Load("Wall"), new Vector3(j, i), Quaternion.identity,tidyParent);
                }
                else
                {
                    Instantiate(Resources.Load("Wall"), new Vector3(j, i), Quaternion.identity, tidyParent);
                    Instantiate(Resources.Load("Wall"), new Vector3(cols-1, i), Quaternion.identity, tidyParent);
                    break;
                }
            }
        }

    }


}
