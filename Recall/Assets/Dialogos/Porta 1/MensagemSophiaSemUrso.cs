using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MensagemSophiaSemUrso : MonoBehaviour {

    InteragirSophia interagir;

    public GameObject ursinho;
    public GameObject panelBox;
    public TextAsset arquivo;
    public string[] texto;
    public Text textoMensagem;

    private int fimDaLinha;
    private int linhaAtual;
    private bool aniversario;

    public bool estaAtivo;

    // Use this for initialization
    void Start()
    {
        interagir = GetComponent<InteragirSophia>();

        if (arquivo != null)
        {
            texto = (arquivo.text.Split('\n'));
        }

        if (fimDaLinha == 0)
        {
            fimDaLinha = texto.Length;
        }

        estaAtivo = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (interagir.Dialogo == true && InteragirUrsinho.Ursinho == false)
        {
            Habilitar();
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (linhaAtual < fimDaLinha)
            {
                textoMensagem.text = texto[linhaAtual];
            }
            if (panelBox.activeSelf)
            {
                linhaAtual += 1;
            }

        }

        if (linhaAtual > fimDaLinha)
        {
            linhaAtual = 0;
            Desabilitar();
        }
    }

    void Habilitar()
    {
        panelBox.SetActive(true);
    }

    void Desabilitar()
    {
        panelBox.SetActive(false);

        estaAtivo = false;
        interagir.Dialogo = false;
    }
}
