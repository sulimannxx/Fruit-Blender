using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RequestCocktail : MonoBehaviour
{
    private List<Color> _requestedCocktailColors = new List<Color>();

    public Color RequestedCocktailColor { get; private set; }

    public event UnityAction<Color> CocktailIsRequested;

    private void Awake()
    {
        _requestedCocktailColors.Add(new Color(0.75f,0.9f,0f,1f));
        _requestedCocktailColors.Add(new Color(0.8f, 0.6f, 0f, 1f));
        _requestedCocktailColors.Add(new Color(0.7f, 0.5f, 0.2f, 1f));
    }

    public void RequestNewCocktail(int id)
    {
        RequestedCocktailColor = _requestedCocktailColors[id];
        Debug.Log(RequestedCocktailColor);
        CocktailIsRequested?.Invoke(RequestedCocktailColor);
    }
}
