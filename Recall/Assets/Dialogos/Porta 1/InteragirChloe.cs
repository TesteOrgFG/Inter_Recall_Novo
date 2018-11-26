 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteragirChloe : MonoBehaviour {

    public GameObject npc;
    public bool entrouChloe;
    public bool Dialogo;

    void Update()
    {
        if (entrouChloe == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Dialogo = true;
                print(Dialogo);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("Entrou");
            entrouChloe = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        print("Ficou");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("saiu");
            entrouChloe = false;
            Dialogo = false;
        }
    }
}
