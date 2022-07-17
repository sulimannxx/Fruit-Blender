using UnityEngine;

public class GreenApple : Fruit
{
    private void Awake()
    {
        FruitColor = new Color(0.5f, 0.9f, 0f, 1f);
    }

    public override void ThrowToBlender()
    {
        ActivateFruit(this);
    }
}
