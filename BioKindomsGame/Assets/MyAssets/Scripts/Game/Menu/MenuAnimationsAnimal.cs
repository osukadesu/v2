using UnityEngine;
using UnityEngine.UI;
public class MenuAnimationsAnimal : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Animator _animWave, _animFade, _animBtn, _animContent;
    [SerializeField] Button btnAnimal;
    void Awake()
    {
        btnAnimal.onClick.AddListener(() => _canvasManager.GoToAnimal());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void AnimFadeAnimal()
    {
        _animFade.SetBool("inanimal", true);
        _animFade.SetBool("govegetal", false);
        _animFade.SetBool("gofungi", false);
        _animFade.SetBool("goprotista", false);
        _animFade.SetBool("gomonera", false);
    }
    public void AnimWaveAnimal()
    {
        _animWave.SetBool("inanimalwave", true);
        _animWave.SetBool("govegetalwave", false);
        _animWave.SetBool("gofungiwave", false);
        _animWave.SetBool("goprotistawave", false);
        _animWave.SetBool("gomonerawave", false);
    }

    public void AnimBtnAnimal()
    {
        _animBtn.SetBool("btninanimal", true);
        _animBtn.SetBool("btngovegetal", false);
        _animBtn.SetBool("btngofungi", false);
        _animBtn.SetBool("btngoprotista", false);
        _animBtn.SetBool("btngomonera", false);
    }
    public void AnimContentAnimal()
    {
        _animContent.SetBool("contentanimal", true);
        _animContent.SetBool("contentgovegetal", false);
        _animContent.SetBool("contentgofungi", false);
        _animContent.SetBool("contentgoprotista", false);
        _animContent.SetBool("contentgomonera", false);
    }
}