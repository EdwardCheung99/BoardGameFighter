using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillList : MonoBehaviour {
    int[,] Skills = new int[6, 10] { { 0,1,1,1,0,0,0,0,0,0 }, 
        { 1,1,1,2,1,1,0,0,0,0},
        { 2, 1, 1, 1, 2, 2, 0, 0, 0, 0 }, 
        { 3, 2, 1, 4, 0, 0, 1, 0, 0, 0 }, 
        { 4, 3, 2, 2, 1, 1, 0, 1, 0, 0 },
        { 5,1, 1, 3, 0, 2, 0, 2, 0, 0 }
    };

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
