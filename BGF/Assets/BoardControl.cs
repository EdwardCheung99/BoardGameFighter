using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoardControl : MonoBehaviour
{
    public Button tile;
    public Canvas Scrin;
    public bool GuessTime = false;
    public bool GuessTime1 = true;
    public bool GuessTime2 = true;
    public string myscene;
    Scene curscene;
    Scene m_scene;

    void Start()
    {
        var script = GetComponent<BC>();
        Debug.Log(script.guess1);
        Debug.Log(script.guess2);
        CreateWorld();
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
    
}