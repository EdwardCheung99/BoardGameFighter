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
    public GameObject P1;
    public GameObject P2;
    public List<Button> tiles = new List<Button>();
    Scene curscene;
    Scene m_scene;

    void Start()
    {
        var script = GetComponent<BC>();
        CreateWorld();
    }

    void CreateWorld()
    {

        for (int x = 0; x < 550; x += 55)
        {
            Button TPos = Instantiate(tile) as Button;
            tiles.Add(TPos);
            TPos.transform.position = new Vector3(x - 247.5f, 0, 0);
            TPos.transform.SetParent(Scrin.transform, false);
            TPos.GetComponent<tileSetup>().posNum = (x / 55) + 1;
            if (TPos.GetComponent<tileSetup>().posNum == 1 || TPos.GetComponent<tileSetup>().posNum == 10)
            {
                TPos.GetComponent<tileSetup>().dmgMod = 1;
            }
            TPos.GetComponentInChildren<Text>().text = "";
            
        }
        Vector2 VP1 = tiles[4].transform.position;
        Vector2 VP2 = tiles[5].transform.position;

        GameObject A1 = Instantiate(P1) as GameObject;
        A1.transform.position = VP1;

        GameObject A2 = Instantiate(P2) as GameObject;
        A2.transform.position = VP2;

    }
    
}