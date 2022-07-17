using UnityEngine;

public class Tomato : Fruit
{
    private void Awake()
    {
        FruitColor = new Color(0.7f, 0f, 0f, 1f);
    }

    public override void ThrowToBlender()
    {
        ActivateFruit(this);
    }
}
