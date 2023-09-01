using UnityEngine;
using UnityEngine.UI;
public class FilmAnimationAnimal : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnFilmAnimal1, btnFilmAnimal2, btnFilmAnimal3, btnFilmAnimal4, btnFilmAnimal5;
    [SerializeField] Animator _animSlideAnimal1, _animSlideAnimal2, _animSlideAnimal3, _animSlideAnimal4, _animSlideAnimal5;
    bool active;
    void Awake()
    {
        btnFilmAnimal1.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmAnimal2.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmAnimal3.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmAnimal4.onClick.AddListener(() => _canvasManager.AnimSlide());
        btnFilmAnimal5.onClick.AddListener(() => _canvasManager.AnimSlide());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void AnimSlide()
    {
        active = !active;
        _animSlideAnimal1.SetBool("slidein", active);
        _animSlideAnimal2.SetBool("slidein", active);
        _animSlideAnimal3.SetBool("slidein", active);
        _animSlideAnimal4.SetBool("slidein", active);
        _animSlideAnimal5.SetBool("slidein", active);
    }
}