using UnityEngine;

public class Banana : Fruit
{
    private void Awake()
    {
        FruitColor = new Color(1f, 0.9f, 0f, 1f);
    }

    public override void ThrowToBlender()
    {
        ActivateFruit(this);
    }
}
