using UnityEngine;
using UnityEngine.UI;
public class MenuAnimationsProtista : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Animator _animWave, _animFade, _animBtn, _animContent;
    [SerializeField] Button btnProtista;
    void Awake()
    {
        btnProtista.onClick.AddListener(() => _canvasManager.GoToProtista());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void AnimFadeProtista()
    {
        _animFade.SetBool("goprotista", true);
        _animFade.SetBool("inanimal", false);
        _animFade.SetBool("govegetal", false);
        _animFade.SetBool("gofungi", false);
        _animFade.SetBool("gomonera", false);
    }
    public void AnimWaveProtista()
    {
        _animWave.SetBool("goprotistawave", true);
        _animWave.SetBool("inanimalwave", false);
        _animWave.SetBool("govegetalwave", false);
        _animWave.SetBool("gofungiwave", false);
        _animWave.SetBool("gomonerawave", false);
    }
    public void AnimBtnProtista()
    {
        _animBtn.SetBool("btngoprotista", true);
        _animBtn.SetBool("btninanimal", false);
        _animBtn.SetBool("btngovegetal", false);
        _animBtn.SetBool("btngofungi", false);
        _animBtn.SetBool("btngomonera", false);
    }
    public void AnimContentProtista()
    {
        _animContent.SetBool("contentgoprotista", true);
        _animContent.SetBool("contentgomonera", false);
        _animContent.SetBool("contentanimal", false);
        _animContent.SetBool("contentgovegetal", false);
        _animContent.SetBool("contentgofungi", false);
    }
}
