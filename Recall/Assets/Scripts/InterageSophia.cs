﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interage : MonoBehaviour {

    private bool entrou;
    public bool dialogoSophia;

    void Update()
    {
        if (entrou == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                dialogoSophia = true;
                print("Diálogo Sophia ");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("Entrou");
            entrou = true;
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
            entrou = false;
        }
    }
}
