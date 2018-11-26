using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MensagemNathan2 : MonoBehaviour {


    public GameObject nathan;
    public GameObject panelBox;
    public TextAsset arquivo;
    public string[] texto;
    public Text textoMensagem;

    private int fimDaLinha;
    private int linhaAtual;

    public bool estaAtivo;
    public static bool telefoneDesligado;
    public static bool sophiaFinal;

    // Use this for initialization
    void Start()
    {

        if (arquivo != null)
        {
            texto = (arquivo.text.Split('\n'));
        }

        if (fimDaLinha == 0)
        {
            fimDaLinha = texto.Length;
        }

        estaAtivo = false;
        sophiaFinal = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (MensagemNathan.telefoneDesligado == true)
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
        MensagemNathan.telefoneDesligado = false;
        sophiaFinal = true;
    }
}
