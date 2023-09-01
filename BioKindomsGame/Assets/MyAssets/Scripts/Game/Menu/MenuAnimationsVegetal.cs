using UnityEngine;
using UnityEngine.UI;
public class MenuAnimationsVegetal : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Animator _animWave, _animFade, _animBtn, _animContent;
    [SerializeField] Button btnVegetal;
    void Awake()
    {
        btnVegetal.onClick.AddListener(() => _canvasManager.GoToVegetal());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void AnimFadeVegetal()
    {
        _animFade.SetBool("govegetal", true);
        _animFade.SetBool("inanimal", false);
        _animFade.SetBool("gofungi", false);
        _animFade.SetBool("goprotista", false);
        _animFade.SetBool("gomonera", false);
    }
    public void AnimWaveVegetal()
    {
        _animWave.SetBool("govegetalwave", true);
        _animWave.SetBool("inanimalwave", false);
        _animWave.SetBool("gofungiwave", false);
        _animWave.SetBool("goprotistawave", false);
        _animWave.SetBool("gomonerawave", false);
    }
    public void AnimBtnVegetal()
    {
        _animBtn.SetBool("btngovegetal", true);
        _animBtn.SetBool("btninanimal", false);
        _animBtn.SetBool("btngofungi", false);
        _animBtn.SetBool("btngoprotista", false);
        _animBtn.SetBool("btngomonera", false);
    }
    public void AnimContentVegetal()
    {
        _animContent.SetBool("contentgovegetal", true);
        _animContent.SetBool("contentgoprotista", false);
        _animContent.SetBool("contentgomonera", false);
        _animContent.SetBool("contentanimal", false);
        _animContent.SetBool("contentgofungi", false);
    }
}
