using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteragirUrsinho : MonoBehaviour
{

    public GameObject SrSnuffles;
    public bool entrouUrsinho;
    public static bool Ursinho;

    void Start()
    {
        Ursinho = false;
        SrSnuffles.SetActive(true);
    }

    void Update()
    {
        if (entrouUrsinho == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Ursinho = true;
                print(Ursinho);
                SrSnuffles.SetActive(false);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("Entrou Ursinho");
            entrouUrsinho = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        print("Ficou Ursinho");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("saiu Ursinho");
            entrouUrsinho = false;
        }
    }
}
