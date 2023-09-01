using UnityEngine;
using UnityEngine.UI;
public class FilmAnimationFungi : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnFilmFungi1, btnFilmFungi2, btnFilmFungi3, btnFilmFungi4, btnFilmFungi5;
    [SerializeField] Animator _animSlideFungi1, _animSlideFungi2, _animSlideFungi3, _animSlideFungi4, _animSlideFungi5;
    bool active;
    void Awake()
    {
        btnFilmFungi1.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmFungi2.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmFungi3.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmFungi4.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmFungi5.onClick.AddListener(() => _canvasManager.AnimSlide());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void AnimSlide()
    {
        active = !active;
        _animSlideFungi1.SetBool("slidein", active);
        _animSlideFungi2.SetBool("slidein", active);
        _animSlideFungi3.SetBool("slidein", active);
        _animSlideFungi4.SetBool("slidein", active);
        _animSlideFungi5.SetBool("slidein", active);
    }
}