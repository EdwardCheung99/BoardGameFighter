using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BC : MonoBehaviour
{
    public Button tile;
    public Canvas Scrin;
    public float TimeSt;
    public float TimeLen = 3f;
    public string guess = "";

    void Start()
    {
        BeginNeutral();

    }

    void Update()
    {
        if (Time.time> TimeSt + TimeLen)
        {
            //change text
        }
    }

    void CreateWorld()
    {

        for (int x = 0; x < 550; x += 55)
        {
            Button TPos = Instantiate(tile) as Button;
            TPos.transform.position = new Vector3(x - 247.5f, 0, 0);
            TPos.transform.SetParent(Scrin.transform, false);
            TPos.GetComponent<tileSetup>().posNum = (x / 55) + 1;
            if (TPos.GetComponent<tileSetup>().posNum == 1 || TPos.GetComponent<tileSetup>().posNum == 10)
            {
                TPos.GetComponent<tileSetup>().dmgMod = 1;
            }
            TPos.GetComponentInChildren<Text>().text = "";
        }
    }

    void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent("k")))
        {
            guess = "high";
            Debug.Log("Guess done");
            //After this is inputted, it switches to the next scene w/ guess variables
        }

    }

    void BeginNeutral()
    {
        //Begin by making text to signal beginning of neutral
        Text StartText_Text;
        RectTransform StartText_RectTrans;

        GameObject newGO = new GameObject("NeutralText"); //make GO for text
        newGO.transform.SetParent(Scrin.transform);
        Text StartText = newGO.AddComponent<Text>();
        StartText.text = "Neutral Phase Begin!";

        StartText_Text = StartText.GetComponent<Text>();
        StartText_RectTrans = StartText.GetComponent<RectTransform>();
        StartText_Text.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
        StartText_Text.fontSize = 30;
        StartText_RectTrans.sizeDelta = new Vector2(StartText_Text.fontSize * 10, 100);
        StartText.rectTransform.localPosition = new Vector3(0f, 0f);

        //Guess phase begins, players select how they choose to block

        

        if (guess != "")
        {
            //go to next scene
        }

    }

}