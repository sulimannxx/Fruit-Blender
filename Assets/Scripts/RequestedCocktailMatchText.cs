using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]

public class RequestedCocktailMatchText : MonoBehaviour
{
    [SerializeField] private CocktailMatchMath _cocktailMatchMath;
    [SerializeField] private GameObject _resultScreen;

    private TMP_Text _resultText;

    private void Awake()
    {
        _resultText = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        _cocktailMatchMath.CocktailMathFinised += ShowResultScreen;
        _resultScreen.SetActive(false);
    }

    private void OnDestroy()
    {
        _cocktailMatchMath.CocktailMathFinised -= ShowResultScreen;
    }

    private void ShowResultScreen()
    {
        _resultScreen.SetActive(true);
        _resultText.text = ($"Your cocktail is {_cocktailMatchMath.TotalResult}% as requested");
    }
}
