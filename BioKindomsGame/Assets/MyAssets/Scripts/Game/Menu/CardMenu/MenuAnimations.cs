using UnityEngine;
public class MenuAnimations : MonoBehaviour
{
    [SerializeField] CanvasGroup canvasGroup;
    [SerializeField]
    Animator _animFadeAnimal, _animBtnAnimal, _animContentAnimal,
     _animFadeVegetal, _animBtnVegetal, _animContentVegetal,
     _animFadeFungi, _animBtnFungi, _animContentFungi,
     _animFadeProtista, _animBtnProtista, _animContentProtista,
     _animFadeMonera, _animBtnMonera, _animContentMonera, _animclose;
    //Animal
    public void AnimFadeAnimal()
    {
        Show();
        _animFadeAnimal.SetBool("inanimal", true);
        _animFadeAnimal.SetBool("govegetal", false);
        _animFadeAnimal.SetBool("gofungi", false);
        _animFadeAnimal.SetBool("goprotista", false);
        _animFadeAnimal.SetBool("gomonera", false);
    }
    public void AnimBtnAnimal()
    {
        Show();
        _animBtnAnimal.SetBool("btninanimal", true);
        _animBtnAnimal.SetBool("btngovegetal", false);
        _animBtnAnimal.SetBool("btngofungi", false);
        _animBtnAnimal.SetBool("btngoprotista", false);
        _animBtnAnimal.SetBool("btngomonera", false);
    }
    public void AnimContentAnimal()
    {
        Show();
        _animContentAnimal.SetBool("contentanimal", true);
        _animContentAnimal.SetBool("contentgovegetal", false);
        _animContentAnimal.SetBool("contentgofungi", false);
        _animContentAnimal.SetBool("contentgoprotista", false);
        _animContentAnimal.SetBool("contentgomonera", false);
    }
    //Vegetal
    public void AnimFadeVegetal()
    {
        Show();
        _animFadeVegetal.SetBool("govegetal", true);
        _animFadeVegetal.SetBool("inanimal", false);
        _animFadeVegetal.SetBool("gofungi", false);
        _animFadeVegetal.SetBool("goprotista", false);
        _animFadeVegetal.SetBool("gomonera", false);
    }
    public void AnimBtnVegetal()
    {
        Show();
        _animBtnVegetal.SetBool("btngovegetal", true);
        _animBtnVegetal.SetBool("btninanimal", false);
        _animBtnVegetal.SetBool("btngofungi", false);
        _animBtnVegetal.SetBool("btngoprotista", false);
        _animBtnVegetal.SetBool("btngomonera", false);
    }
    public void AnimContentVegetal()
    {
        Show();
        _animContentVegetal.SetBool("contentgovegetal", true);
        _animContentVegetal.SetBool("contentgoprotista", false);
        _animContentVegetal.SetBool("contentgomonera", false);
        _animContentVegetal.SetBool("contentanimal", false);
        _animContentVegetal.SetBool("contentgofungi", false);
    }
    //Fungi
    public void AnimFadeFungi()
    {
        Show();
        _animFadeFungi.SetBool("gofungi", true);
        _animFadeFungi.SetBool("inanimal", false);
        _animFadeFungi.SetBool("govegetal", false);
        _animFadeFungi.SetBool("goprotista", false);
        _animFadeFungi.SetBool("gomonera", false);
    }
    public void AnimBtnFungi()
    {
        Show();
        _animBtnFungi.SetBool("btngofungi", true);
        _animBtnFungi.SetBool("btninanimal", false);
        _animBtnFungi.SetBool("btngovegetal", false);
        _animBtnFungi.SetBool("btngoprotista", false);
        _animBtnFungi.SetBool("btngomonera", false);
    }
    public void AnimContentFungi()
    {
        Show();
        _animContentFungi.SetBool("contentanimal", false);
        _animContentFungi.SetBool("contentgovegetal", false);
        _animContentFungi.SetBool("contentgofungi", true);
        _animContentFungi.SetBool("contentgoprotista", false);
        _animContentFungi.SetBool("contentgomonera", false);
    }
    //Protista
    public void AnimFadeProtista()
    {
        Show();
        _animFadeProtista.SetBool("goprotista", true);
        _animFadeProtista.SetBool("inanimal", false);
        _animFadeProtista.SetBool("govegetal", false);
        _animFadeProtista.SetBool("gofungi", false);
        _animFadeProtista.SetBool("gomonera", false);
    }
    public void AnimBtnProtista()
    {
        Show();
        _animBtnProtista.SetBool("btngoprotista", true);
        _animBtnProtista.SetBool("btninanimal", false);
        _animBtnProtista.SetBool("btngovegetal", false);
        _animBtnProtista.SetBool("btngofungi", false);
        _animBtnProtista.SetBool("btngomonera", false);
    }
    public void AnimContentProtista()
    {
        Show();
        _animContentProtista.SetBool("contentgoprotista", true);
        _animContentProtista.SetBool("contentgomonera", false);
        _animContentProtista.SetBool("contentanimal", false);
        _animContentProtista.SetBool("contentgovegetal", false);
        _animContentProtista.SetBool("contentgofungi", false);
    }
    //Monera
    public void AnimFadeMonera()
    {
        Show();
        _animFadeMonera.SetBool("gomonera", true);
        _animFadeMonera.SetBool("inanimal", false);
        _animFadeMonera.SetBool("govegetal", false);
        _animFadeMonera.SetBool("gofungi", false);
        _animFadeMonera.SetBool("goprotista", false);
    }
    public void AnimBtnMonera()
    {
        Show();
        _animBtnMonera.SetBool("btngomonera", true);
        _animBtnMonera.SetBool("btninanimal", false);
        _animBtnMonera.SetBool("btngovegetal", false);
        _animBtnMonera.SetBool("btngofungi", false);
        _animBtnMonera.SetBool("btngoprotista", false);
    }
    public void AnimContentMonera()
    {
        Show();
        _animContentMonera.SetBool("contentgomonera", true);
        _animContentMonera.SetBool("contentanimal", false);
        _animContentMonera.SetBool("contentgovegetal", false);
        _animContentMonera.SetBool("contentgofungi", false);
        _animContentMonera.SetBool("contentgoprotista", false);
    }
    void Show()
    {
        canvasGroup.alpha = 1; canvasGroup.interactable = true; canvasGroup.blocksRaycasts = true;
    }
    public void CloseAll()
    {
        canvasGroup.alpha = 0; canvasGroup.interactable = false; canvasGroup.blocksRaycasts = false;
    }
}