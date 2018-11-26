using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteragirTelefone : MonoBehaviour {

    public GameObject chamadaTelefone;

    public bool entrouTelefone;
    public bool atendeTelefone;

    void Start()
    {
        atendeTelefone = false;
    }

    void Update()
    {
        if (entrouTelefone == true)
        {
            if (Input.GetKeyDown(KeyCode.E) && MensagemChloeTelefone.telefoneToca == true)
            {
                atendeTelefone = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("Entrou Telefone");
            entrouTelefone = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        print("Ficou Telefone");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("saiu Telefone");
            entrouTelefone = false;
        }
    }
}
