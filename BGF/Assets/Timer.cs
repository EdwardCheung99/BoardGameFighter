using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public float thetimer = 15;
    public Text TextTimer;


	// Use this for initialization
	void Start () {
        TextTimer = GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
        TextTimer.text = (thetimer % 60).ToString("00");
    }
}
