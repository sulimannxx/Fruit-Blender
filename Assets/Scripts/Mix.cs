using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class Mix : MonoBehaviour
{
    [SerializeField] private BlenderCup _blender;
    [SerializeField] private CocktailInBlender _cocktailInBlender;
    [SerializeField] private Cap _cap;

    private Button _mixButton;

    private void Awake()
    {
        _mixButton = GetComponent<Button>();
    }

    public void OnButtonClick()
    {
        _blender.Shake();
        _mixButton.enabled = false;
        _cocktailInBlender.SetColorOfCocktail();
        _cocktailInBlender.RiseCocktail();
        _cap.PlayCloseAnimation();
    }
}
