using UnityEngine;
using UnityEngine.Events;

public class CocktailMatchMath : MonoBehaviour
{
    [SerializeField] private Cocktail _cocktail;
    [SerializeField] private RequestCocktail _requestCocktail;
    [SerializeField] private CocktailInBlender _cocktailInBlender;

    public event UnityAction CocktailMathFinised;

    public int TotalResult { get; private set; }

    private void Start()
    {
        _cocktailInBlender.BlendingFinished += OnBlendingFinished;
    }

    private void OnDestroy()
    {
        _cocktailInBlender.BlendingFinished -= OnBlendingFinished;
    }

    public void OnBlendingFinished()
    {
        float resultR = (_requestCocktail.RequestedCocktailColor.r + _cocktail.CurrentColor.r) / 2f;
        resultR = _requestCocktail.RequestedCocktailColor.r / resultR;

        if (resultR > 1f)
        {
            resultR = 1f / resultR * 100f;
        }
        else if (resultR <= 1f)
        {
            resultR *= 100f;
        }
        else if (float.IsNaN(resultR) || float.IsInfinity(resultR))
        {
            resultR = 100f;
        }

        float resultG = (_requestCocktail.RequestedCocktailColor.g + _cocktail.CurrentColor.g) / 2f;
        resultG = _requestCocktail.RequestedCocktailColor.g / resultG;

        if (resultG > 1f)
        {
            resultG = 1f / resultG * 100f;
        }
        else if (resultG <= 1f)
        {
            resultG *= 100f;
        }
        else if (float.IsNaN(resultG) || float.IsInfinity(resultG))
        {
            resultG = 100f;
        }

        float resultB = (_requestCocktail.RequestedCocktailColor.b + _cocktail.CurrentColor.b) / 2f;
        resultB = _requestCocktail.RequestedCocktailColor.b / resultB;

        if (resultB > 1f)
        {
            resultB = 1f / resultB * 100f;
        }
        else if (resultB <= 1f)
        {
            resultB *= 100f;
        }
        else if (float.IsNaN(resultB) || float.IsInfinity(resultB))
        {
            resultB = 100f;
        }

        TotalResult = (int) ((resultR + resultG + resultB) / 3);

        CocktailMathFinised?.Invoke();
    }
}
