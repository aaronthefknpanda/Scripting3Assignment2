using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private GameObject P1;
    private GameObject P2;
    private GameObject P3;
    private GameObject P4;
    private GameObject P5;
    private GameObject P6;
    private GameObject P7;
    private GameObject P8;
    private GameObject P9;

    private GameObject player;

    private GameObject text;

    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();
            }

            return _instance;
        }
    }


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        P1 = GameObject.Find("Panel 1");
        P2 = GameObject.Find("Panel 2");
        P3 = GameObject.Find("Panel 3");
        P4 = GameObject.Find("Panel 4");
        P5 = GameObject.Find("Panel 5");
        P6 = GameObject.Find("Panel 6");
        P7 = GameObject.Find("Panel 7");
        P8 = GameObject.Find("Panel 8");
        P9 = GameObject.Find("Panel 9");

        player = GameObject.Find("Player");

        text = GameObject.Find("Text");
        text.GetComponent<Text>().enabled = false;
    }
    void Update()
    {
        if(P1.GetComponent<Panel>().correct  == true &&
            P2.GetComponent<Panel>().correct == true &&
            P3.GetComponent<Panel>().correct == true &&
            P4.GetComponent<Panel>().correct == true &&
            P5.GetComponent<Panel>().correct == true &&
            P6.GetComponent<Panel>().correct == true &&
            P7.GetComponent<Panel>().correct == true &&
            P8.GetComponent<Panel>().correct == true &&
            P9.GetComponent<Panel>().correct == true)
        {
            Debug.Log("You win!");
            player.GetComponent<PlayerMovement>().speed = 0;
            text.GetComponent<Text>().enabled = true;

        }
    }
}
