using UnityEngine;

public class ThrowFruitButton : MonoBehaviour
{
    [SerializeField] private Fruit _fruit;
    [SerializeField] private Cap _cap;
    [SerializeField] private BlenderCup _blender;

    public void OnButtonClick()
    {
        _fruit.ThrowToBlender();
        _cap.PlayOpenAnimation();
        _blender.AddFruitToBlender(_fruit);
    }
}
