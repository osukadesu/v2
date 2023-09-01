using UnityEngine;
using UnityEngine.UI;
public class MenuAnimationsFungi : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Animator _animWave, _animFade, _animBtn, _animContent;
    [SerializeField] Button btnFungi;
    void Awake()
    {
        btnFungi.onClick.AddListener(() => _canvasManager.GoToFungi());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void AnimFadeFungi()
    {
        _animFade.SetBool("gofungi", true);
        _animFade.SetBool("inanimal", false);
        _animFade.SetBool("govegetal", false);
        _animFade.SetBool("goprotista", false);
        _animFade.SetBool("gomonera", false);
    }
    public void AnimWaveFungi()
    {
        _animWave.SetBool("gofungiwave", true);
        _animWave.SetBool("inanimalwave", false);
        _animWave.SetBool("govegetalwave", false);
        _animWave.SetBool("goprotistawave", false);
        _animWave.SetBool("gomonerawave", false);
    }
    public void AnimBtnFungi()
    {
        _animBtn.SetBool("btngofungi", true);
        _animBtn.SetBool("btninanimal", false);
        _animBtn.SetBool("btngovegetal", false);
        _animBtn.SetBool("btngoprotista", false);
        _animBtn.SetBool("btngomonera", false);
    }
    public void AnimContentFungi()
    {
        _animContent.SetBool("contentanimal", false);
        _animContent.SetBool("contentgovegetal", false);
        _animContent.SetBool("contentgofungi", true);
        _animContent.SetBool("contentgoprotista", false);
        _animContent.SetBool("contentgomonera", false);
    }
}
