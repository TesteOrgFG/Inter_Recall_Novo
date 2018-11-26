using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteragirSophia : MonoBehaviour {


    public GameObject npc;
    public bool entrouSophia;
    public bool Dialogo;


    void Update()
    {
        if (entrouSophia == true)
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
            entrouSophia = true;
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
            entrouSophia = false;
            Dialogo = false;
        }
    }
}
