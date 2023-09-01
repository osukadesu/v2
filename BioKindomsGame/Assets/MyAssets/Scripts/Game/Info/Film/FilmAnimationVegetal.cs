using UnityEngine;
using UnityEngine.UI;
public class FilmAnimationVegetal : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnFilmVegetal1, btnFilmVegetal2, btnFilmVegetal3, btnFilmVegetal4, btnFilmVegetal5;
    [SerializeField] Animator _animSlideVegetal1, _animSlideVegetal2, _animSlideVegetal3, _animSlideVegetal4, _animSlideVegetal5;
    bool active;
    void Awake()
    {
        btnFilmVegetal1.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmVegetal2.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmVegetal3.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmVegetal4.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmVegetal5.onClick.AddListener(() => _canvasManager.AnimSlide());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void AnimSlide()
    {
        active = !active;
        _animSlideVegetal1.SetBool("slidein", active);
        _animSlideVegetal2.SetBool("slidein", active);
        _animSlideVegetal3.SetBool("slidein", active);
        _animSlideVegetal4.SetBool("slidein", active);
        _animSlideVegetal5.SetBool("slidein", active);
    }
}