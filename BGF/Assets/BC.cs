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
        CreateWorld();
    }

    void Update()
    {

    }

    void CreateWorld()
    {

        for (int x = 0; x < 550; x+= 55)
        {
                Button TPos = Instantiate(tile) as Button;
                TPos.transform.position = new Vector3(x - 247.5f, 0, 0);
                TPos.transform.SetParent(Scrin.transform, false);
                TPos.GetComponentInChildren<Text>().text = "";
        }
    }

}