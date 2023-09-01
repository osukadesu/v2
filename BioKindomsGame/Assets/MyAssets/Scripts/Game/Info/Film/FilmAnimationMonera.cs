using UnityEngine;
using UnityEngine.UI;
public class FilmAnimationMonera : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnFilmMonera1, btnFilmMonera2, btnFilmMonera3, btnFilmMonera4, btnFilmMonera5;
    [SerializeField] Animator _animSlideMonera1, _animSlideMonera2, _animSlideMonera3, _animSlideMonera4, _animSlideMonera5;
    bool active;
    void Awake()
    {
        btnFilmMonera1.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmMonera2.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmMonera3.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmMonera4.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmMonera5.onClick.AddListener(() => _canvasManager.AnimSlide());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void AnimSlide()
    {
        active = !active;
        _animSlideMonera1.SetBool("slidein", active);
        _animSlideMonera2.SetBool("slidein", active);
        _animSlideMonera3.SetBool("slidein", active);
        _animSlideMonera4.SetBool("slidein", active);
        _animSlideMonera5.SetBool("slidein", active);
    }
}