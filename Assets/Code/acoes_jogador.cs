using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class acoes_jogador : MonoBehaviour
{
    public int[] Uva_escolhida;
    public int terreno_escolhido;
    public int dinheiro;
    public GameObject canvas1;
    public bool pertoPilar = false;
    public bool uiAberta;
    public Text dinheiro_texto;
    public Button botão_merlo;
    public Button botão_malbec;
    public Button botão_cabernet;

    void Start()
    {
        dinheiro = 100;
       
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && pertoPilar && !uiAberta)
        {
            canvas1.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            uiAberta = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && uiAberta)
        {
            canvas1.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            uiAberta = false;
        }

        dinheiro_texto.text = dinheiro.ToString(); 

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Pilar"))
        {
            pertoPilar = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Pilar"))
        {
            pertoPilar = false;
        }
        canvas1.SetActive(false); 
    }

    public void Clicou_cabernet()
    {
        print("cabernet"); 
    }
    public void Clicou_merlot()
    {
        print("merlot");
    }

    public void Clicou_malbec()
    {
        print("malbec");
    }
}

