using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardControl : MonoBehaviour {
    public GameObject tile;
	// Use this for initialization
	void Start () {
        //Make 5 tiles
        for (int i = 0; i == 5; i++)
        {
            GameObject b;
            //Tile Creation
            b = Instantiate(tile, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
            tileSetup pn = b.GetComponent<tileSetup>(); //Allows me to pull variables from the current tile
               pn.posNum = i;
            if (i == 0 || i == 5)
            {
               pn.dmgMod  = 1; //Corner = +1 dmg
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void BeginNeutralPhase (){
        
    }
}
