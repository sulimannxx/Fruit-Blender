using UnityEngine;

public class MessageBubbleAnimation : MonoBehaviour
{
    [SerializeField] private RequestCocktail _requestedCocktailColor;

    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
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
    }
}
