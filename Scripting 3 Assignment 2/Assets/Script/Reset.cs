using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;
    public GameObject panel7;
    public GameObject panel8;
    public GameObject panel9;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Restart();
        }
    }

    void Restart()
    {
        panel1.SendMessage("squareOne");
        panel2.SendMessage("squareOne");
        panel3.SendMessage("squareOne");
        panel4.SendMessage("squareOne");
        panel5.SendMessage("squareOne");
        panel6.SendMessage("squareOne");
        panel7.SendMessage("squareOne");
        panel8.SendMessage("squareOne");
        panel9.SendMessage("squareOne");
    }
}
