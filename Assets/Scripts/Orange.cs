using UnityEngine;

public class Orange : Fruit
{
    private void Awake()
    {
        FruitColor = new Color(0.9f, 0.7f, 0f, 1f);
    }

    public override void ThrowToBlender()
    {
        ActivateFruit(this);
    }
}
