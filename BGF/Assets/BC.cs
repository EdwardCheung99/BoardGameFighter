using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BC : MonoBehaviour
{
    public Button tile;
    public Canvas Scrin;
    

    void Start()
    {
        BeginNeutral();

    }

    void Update()
    {

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

    void BeginNeutral()
    {
        //Begin by making GO for text to tell players what to do
        Text StartText_Text;
        RectTransform StartText_RectTrans;

        GameObject newGO = new GameObject("NeutralText");
        newGO.transform.SetParent(Scrin.transform);

        Text StartText = newGO.AddComponent<Text>();
        StartText.text = "Neutral Phase Begin!";

        StartText_Text = StartText.GetComponent<Text>();
        StartText_RectTrans = StartText.GetComponent<RectTransform>();

        StartText_Text.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
        StartText_Text.fontSize = 30;
        StartText_RectTrans.sizeDelta = new Vector2(StartText_Text.fontSize * 10, 100);
        StartText.rectTransform.localPosition = new Vector3(0f, 0f);
    }

}