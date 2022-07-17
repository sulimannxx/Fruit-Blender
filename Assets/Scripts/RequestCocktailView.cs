using UnityEngine;

public class RequestCocktailView : MonoBehaviour
{
    [SerializeField] private RequestCocktail _requestedCocktailColor;
    [SerializeField] private Animator _animator;

    private string _bubbleAnimationName = "RequestCocktail";
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _requestedCocktailColor.CocktailIsRequested += OnNewCocktailRequested;
    }

    private void OnDestroy()
    {
        _requestedCocktailColor.CocktailIsRequested -= OnNewCocktailRequested;
    }

    private void OnNewCocktailRequested(Color cocktailColor)
    {
        _spriteRenderer.color = cocktailColor;
        _animator.Play(_bubbleAnimationName);
    }
}
