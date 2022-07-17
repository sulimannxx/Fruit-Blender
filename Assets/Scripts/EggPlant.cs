using UnityEngine;

public class EggPlant : Fruit
{
    private void Awake()
    {
        FruitColor = new Color(0f, 0f, 0.2f, 1f);
    }

    public override void ThrowToBlender()
    {
        ActivateFruit(this);
    }
}
