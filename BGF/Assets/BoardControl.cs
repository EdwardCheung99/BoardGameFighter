using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardControl : MonoBehaviour {
    public GameObject canCV;
    // Use this for initialization
    void Start () {
        //Make 10 tiles
        for (int i = 0; i == 10; i++)
        {
            GameObject b = new GameObject();
            //Tile Creation
            RectTransform Rect = b.AddComponent<RectTransform>();
            tileSetup pn = b.AddComponent<tileSetup>(); //Allows me to pull variables from the current tile
            Rect.sizeDelta = new Vector2(200.0f * i, 100.0f);

            pn.posNum = i;
            if (i == 0 || i == 10)
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
