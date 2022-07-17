using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetLevel : MonoBehaviour
{
    [SerializeField] private List<Transform> _fruitsTransforms;
    [SerializeField] private List<Fruit> _fruits;
    [SerializeField] private MeshRenderer _cocktailColor;
    [SerializeField] private CocktailInBlender _cocktailInBlender;
    [SerializeField] private Button _mixButton;
    [SerializeField] private Cocktail _cocktail;

    private List<Transform> _fruitsInitialTransforms = new List<Transform>();
    private Vector3 _cocktailInBlenderStartPosition;

    private void Start()
    {
        foreach (var fruit in _fruitsTransforms)
        {
            _fruitsInitialTransforms.Add(fruit.transform);
        }

        _cocktailInBlenderStartPosition = _cocktailInBlender.transform.position;
    }

    public void ResetFruitTransforms()
    {
        for (int i = 0; i < _fruitsInitialTransforms.Count; i++)
        {
            _fruitsTransforms[i] = _fruitsInitialTransforms[i];
        }
    }

    public void DisableFruits()
    {
        foreach (var fruit in _fruitsTransforms)
        {
            fruit.gameObject.SetActive(false);
        }
    }

    public void ResetFruitsInBlenderState()
    {
        foreach (var fruit in _fruits)
        {
            fruit.ResetInBlenderState();
        }
    }

    public void ResetBlenderCocktailColor()
    {
        _cocktailColor.material.color = new Color(0f, 0f, 0f, 1f);
    }

    public void ResetCocktailInBlenderPosition()
    {
        _cocktailInBlender.transform.position = _cocktailInBlenderStartPosition;
    }

    public void ActivateMixButton()
    {
        _mixButton.enabled = true;
    }

    public void ResetCocktail()
    {
        _cocktail.ResetCocktail();
    }
}
