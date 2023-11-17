using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class TextGralController : MonoBehaviour
{
    [SerializeField] Animator txtAnim;
    [SerializeField] Text textGral;

    public void ShowText(string message)
    {
        textGral.text = message;
        txtAnim.SetBool("txtinfogral", true);
    }
    public void HideText()
    {
        textGral.text = "";
        txtAnim.SetBool("txtinfogral", false);
    }
    public void StartingAT(String anytext2)
    {
        StartCoroutine(AnyText(anytext2));
    }
    IEnumerator AnyText(string anytext)
    {
        ShowText(anytext);
        yield return new WaitForSeconds(0.5f);
        HideText();
    }
    public void StartingWTLT(int level2)
    {
        StartCoroutine(WelcomeToLevelText(level2));
    }
    IEnumerator WelcomeToLevelText(int level)
    {
        ShowText($"Bienvenido al nivel {level}");
        yield return new WaitForSeconds(0.5f);
        HideText();
    }
    public void StartingIOT()
    {
        StartCoroutine(ItemObjectText());
    }
    IEnumerator ItemObjectText()
    {
        ShowText("Partida guardada!");
        yield return new WaitForSeconds(0.5f);
        HideText();
    }
}
/*
 public void MessageText()
    {
        StartCoroutine(TextFade());
    }
    public void TextView()
    {
        textGral.text = myMessage;
        txtAnim.SetBool("txtinfogral", true);
    }
    public void TextHide()
    {
        textGral.text = "";
        txtAnim.SetBool("txtinfogral", false);
    }
    IEnumerator TextFade()
    {
        TextView();
        yield return new WaitForSeconds(1.5f);
        TextHide();
    }
*/