using UnityEngine;
using UnityEngine.UI;
public class FilmAnimationProtista : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnFilmProtista1, btnFilmProtista2, btnFilmProtista3, btnFilmProtista4, btnFilmProtista5;
    [SerializeField] Animator _animSlideProtista1, _animSlideProtista2, _animSlideProtista3, _animSlideProtista4, _animSlideProtista5;
    bool active;
    void Awake()
    {
        btnFilmProtista1.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmProtista2.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmProtista3.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmProtista4.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmProtista5.onClick.AddListener(() => _canvasManager.AnimSlide());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void AnimSlide()
    {
        active = !active;
        _animSlideProtista1.SetBool("slidein", active);
        _animSlideProtista2.SetBool("slidein", active);
        _animSlideProtista3.SetBool("slidein", active);
        _animSlideProtista4.SetBool("slidein", active);
        _animSlideProtista5.SetBool("slidein", active);
    }
}