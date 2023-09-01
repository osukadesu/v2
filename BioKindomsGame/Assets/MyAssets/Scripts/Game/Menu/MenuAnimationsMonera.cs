using UnityEngine;
using UnityEngine.UI;
public class MenuAnimationsMonera : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Animator _animWave, _animFade, _animBtn, _animContent;
    [SerializeField] Button btnMonera;
    void Awake()
    {
        btnMonera.onClick.AddListener(() => _canvasManager.GoToMonera());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void AnimFadeMonera()
    {
        _animFade.SetBool("gomonera", true);
        _animFade.SetBool("inanimal", false);
        _animFade.SetBool("govegetal", false);
        _animFade.SetBool("gofungi", false);
        _animFade.SetBool("goprotista", false);
    }
    public void AnimWaveMonera()
    {
        _animWave.SetBool("gomonerawave", true);
        _animWave.SetBool("inanimalwave", false);
        _animWave.SetBool("govegetalwave", false);
        _animWave.SetBool("gofungiwave", false);
        _animWave.SetBool("goprotistawave", false);
    }
    public void AnimBtnMonera()
    {
        _animBtn.SetBool("btngomonera", true);
        _animBtn.SetBool("btninanimal", false);
        _animBtn.SetBool("btngovegetal", false);
        _animBtn.SetBool("btngofungi", false);
        _animBtn.SetBool("btngoprotista", false);
    }
    public void AnimContentMonera()
    {
        _animContent.SetBool("contentgomonera", true);
        _animContent.SetBool("contentanimal", false);
        _animContent.SetBool("contentgovegetal", false);
        _animContent.SetBool("contentgofungi", false);
        _animContent.SetBool("contentgoprotista", false);
    }
}
