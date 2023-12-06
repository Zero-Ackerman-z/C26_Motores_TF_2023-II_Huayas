using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoPrincipal : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public TextMeshProUGUI textoTMP;

    void Start()
    {
        StartCoroutine(ControlarVisibilidadTexto());
    }

    IEnumerator ControlarVisibilidadTexto()
    {
        while (true)
        {
            // Mostrar el texto gradualmente
            for (float alpha = 0; alpha <= 1; alpha += 0.05f)
            {
                canvasGroup.alpha = alpha;
                yield return new WaitForSeconds(0.05f);
            }

            yield return new WaitForSeconds(1); // Espera

            // Ocultar el texto gradualmente
            for (float alpha = 1; alpha >= 0; alpha -= 0.05f)
            {
                canvasGroup.alpha = alpha;
                yield return new WaitForSeconds(0.05f);
            }

            yield return new WaitForSeconds(1); // Espera
        }
    }
}
