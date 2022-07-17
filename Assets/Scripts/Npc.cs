using UnityEngine;

public class Npc : MonoBehaviour
{
    [SerializeField] private RequestCocktail _npcCocktail;

    private int _requestCocktailId;

    private void Start()
    {
        _npcCocktail.RequestNewCocktail(_requestCocktailId);
    }

    public void RequestNewLevelCocktail()
    {
        _requestCocktailId++;

        if (_requestCocktailId > 2)
        {
            _requestCocktailId = 0;
        }

        _npcCocktail.RequestNewCocktail(_requestCocktailId);
    }
}
