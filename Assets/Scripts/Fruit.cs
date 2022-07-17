using System.Collections;
using UnityEngine;

public abstract class Fruit : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] protected Cocktail _cocktail;

    private string _throwAnimationName = "FruitJump";

    public Color FruitColor { get; protected set; }
    public bool FruitIsInBlender { get; private set; } = false;

    private IEnumerator StopAnimation(Fruit fruit)
    {
        yield return new WaitForSeconds(1.65f);
        fruit._animator.enabled = false;
    }

    public abstract void ThrowToBlender();

    public void ActivateFruit(Fruit fruit)
    {
        fruit.gameObject.SetActive(true);

        if (fruit.FruitIsInBlender == false)
        {
            fruit._animator.enabled = true;
            fruit._animator.Play(_throwAnimationName);
            StartCoroutine(StopAnimation(fruit));
            _cocktail.AddFruitToCocktail(FruitColor);
        }

        fruit.FruitIsInBlender = true;
    }

    public void ResetInBlenderState()
    {
        FruitIsInBlender = false;
    }
}
