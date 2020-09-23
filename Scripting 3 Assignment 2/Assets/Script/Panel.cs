using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;
using System.Numerics;

public class Panel : MonoBehaviour
{
    private SpriteRenderer sprite;                              
    public bool correct;

    public GameObject neighbor1;
    public GameObject neighbor2;
    public GameObject neighbor3;
    public GameObject neighbor4;

    //public List<GameObject> neighbors;                                

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        correct = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ChangeColor();
            ChangeNeighborColor();
        }
    }
    public void ChangeColor()
    {
        if (!correct)
        {
            sprite.color = Color.green;
            correct = true;
            transform.DOPunchRotation(new UnityEngine.Vector3(0.0f, 0.0f, 10.0f), 0.5f, 1, 0.5f);
            return;
        }

        if (correct)
        {
            sprite.color = Color.red;
            correct = false;
            transform.DOPunchRotation(new UnityEngine.Vector3(0.0f, 0.0f, 10.0f), 0.5f, 1, 0.5f);
            return;
        }
    }

    void ChangeNeighborColor()
    {
        if(neighbor1 != null)
        {
            neighbor1.SendMessage("ChangeColor");
        }
        else
        {
            return;
        }

        if (neighbor2 != null)
        {
            neighbor2.SendMessage("ChangeColor");
        }
        else
        {
            return;
        }

        if (neighbor3 != null)
        {
            neighbor3.SendMessage("ChangeColor");
        }
        else
        {
            return;
        }

        if (neighbor4 != null)
        {
            neighbor4.SendMessage("ChangeColor");
        }
        else
        {
            return;
        }
    }

    public void squareOne()
    {
        sprite.color = Color.red;
        correct = false;
        transform.DOPunchPosition(new UnityEngine.Vector3(0.3f, 0.0f, 0.0f), 0.5f);
    }
}
