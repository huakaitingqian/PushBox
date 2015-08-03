using UnityEngine;
using System.Collections;

public class Data : MonoBehaviour {

	// Use this for initialization
    static int mapWidth = 15;
    static int mapHeight = 15;
	
    public static int GetMapWidth()
    {
        return mapWidth;
    }

    public static int GetMapHeight()
    {
        return mapHeight;
    }

    public static void SetMapWidth(int w) 
    {
        mapWidth = w;
    }

    public static void SetMapHeight(int h)
    {
        mapHeight = h;
    }



	// Update is called once per frame
	void Update () {
	
	}
}
