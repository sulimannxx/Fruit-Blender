using UnityEngine;

public class TryAgainButton : MonoBehaviour
{
    [SerializeField] private CocktailMatchMath _cocktailMatchMath;
    [SerializeField] private ResetLevel _resetLevel;
    [SerializeField] private GameObject _matchPlate;
    [SerializeField] private GameObject _tryAgainButton;

    private void Start()
    {
        _cocktailMatchMath.CocktailMathFinised += OnMathCalculated;
        gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        _cocktailMatchMath.CocktailMathFinised -= OnMathCalculated;
    }

    private void OnMathCalculated()
    {
        if (_cocktailMatchMath.TotalResult <= 75)
        {
            gameObject.SetActive(true);
        }
    }

    public void OnButtonClick()
    {
        _resetLevel.ResetFruitTransforms();
        _resetLevel.DisableFruits();
        _resetLevel.ResetBlenderCocktailColor();
        _resetLevel.ResetFruitsInBlenderState();
        _resetLevel.ResetCocktailInBlenderPosition();
        _resetLevel.ActivateMixButton();
        _resetLevel.ResetCocktail();
        _matchPlate.SetActive(false);
        _tryAgainButton.SetActive(false);
    }
}
