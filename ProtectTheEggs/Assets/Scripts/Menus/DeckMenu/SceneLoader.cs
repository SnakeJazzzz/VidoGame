using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public UserInformation userInformation;
    public RSRSCards mazos;
    public GameObject TextoMensajeNoEspacio;
    public void CreateNewDeck()
    {
        if (mazos.Items[mazos.Items.Count - 1].nombreMazo != "")
        {
            StartCoroutine(mensajeNoEspacio());
            // Debug.Log("No tienes espacio para crear otro mazo");
        }
        else
        {
            int firstEmpty = mazos.Items.Count - 1;
            for (int i = 0; i < mazos.Items.Count - 1; i++)
            {
                if (mazos.Items[i].nombreMazo == "")
                {
                    firstEmpty = i;
                    break;
                }
            }

            userInformation.selectedDeck = firstEmpty;
            //Debug.Log("Cambiando a Escena DeckBuilder");
            SceneManager.LoadScene("DeckBuilder");
        }
    }

    public void EditDeck()
    {
        SceneManager.LoadScene("DeckBuilder");
    }

    IEnumerator mensajeNoEspacio()
    {
        Debug.Log("No tienes espacio para crear otro mazo");
        TextoMensajeNoEspacio.SetActive(true);
        yield return new WaitForSeconds(2f);
        TextoMensajeNoEspacio.SetActive(false);
    }
}
