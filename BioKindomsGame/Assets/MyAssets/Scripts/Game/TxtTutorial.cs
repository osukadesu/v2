using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TxtTutorial : MonoBehaviour
{
    [SerializeField] Text txtTutorial;
    public Animator txtAnim;
    private void Start()
    {
        if (MenuController.instance.IsNewGame)
        {
            txtAnim.SetBool("txtinfogral", true);
            txtTutorial.text = "Ve por el mapa y guarda las cajas!";
            StartCoroutine("FadeText");
        }
    }
    IEnumerator FadeText()
    {
        yield return new WaitForSeconds(2f);
        txtTutorial.text = "";
        yield return new WaitForSeconds(1f);
        txtAnim.SetBool("txtinfogral", false);
    }
}