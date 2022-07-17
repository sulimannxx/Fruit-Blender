using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(MeshRenderer))]

public class CocktailInBlender : MonoBehaviour
{
    [SerializeField] private Cocktail _cocktail;

    private MeshRenderer _cocktailMesh;
    private float _cocktailMaxHeight = 1.22f;

    public event UnityAction BlendingFinished;

    private void Awake()
    {
        _cocktailMesh = GetComponent<MeshRenderer>();
    }

    private IEnumerator MoveCocktailInCup()
    {
        while (transform.position.y < _cocktailMaxHeight)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime / 20f,
                transform.position.z);
            yield return null;
        }

        BlendingFinished?.Invoke();
    }

    public void SetColorOfCocktail()
    {
        _cocktail.MixCocktail();
        _cocktailMesh.material.color = _cocktail.CurrentColor;
    }

    public void RiseCocktail()
    {
        StartCoroutine(MoveCocktailInCup());
    }
}
