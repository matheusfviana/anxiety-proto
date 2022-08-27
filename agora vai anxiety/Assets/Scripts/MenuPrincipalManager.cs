using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPrincipalManager : MonoBehaviour
{

    [SerializeField] private string nome_do_nvl_do_jogo;
    [SerializeField] private GameObject painel_menu_principal;
    [SerializeField] private GameObject painel_controles;
    [SerializeField]  GameObject cutscene1;
    [SerializeField]  GameObject cutscene2;
    [SerializeField]  GameObject cutscene3;
    [SerializeField]  GameObject cutscene4;
    [SerializeField]  GameObject dica1;

   

    public void jogar()
    {
            
            painel_menu_principal.SetActive(false);
            cutscene1.SetActive(true);

    }
    public void c1()
    {
            cutscene1.SetActive(false);
            cutscene2.SetActive(true);


    }
    public void c2()
    {
            cutscene2.SetActive(false);
            cutscene3.SetActive(true);


    }
    public void c3()
    {
            cutscene3.SetActive(false);
            cutscene4.SetActive(true);


    }
    public void c4()
    {
            cutscene4.SetActive(false);
            dica1.SetActive(true);


    }
    public void d1()
    {
            
            SceneManager.LoadScene(nome_do_nvl_do_jogo);


    }

    public void controles()
    {
            painel_menu_principal.SetActive(false);
            painel_controles.SetActive(true);


    }
    
    IEnumerator TimeDelay()
            {
                yield return new WaitForSeconds(5);

            }

    public void voltarc()
    {
            painel_menu_principal.SetActive(true);
            painel_controles.SetActive(false);

    }

    public void sair()
    {
            Debug.Log("Sair do Jogo");
            Application.Quit();


    }

}
