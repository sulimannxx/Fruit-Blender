using UnityEngine;

public class Cherry : Fruit
{
    private void Awake()
    {
        FruitColor = new Color(1f, 0.2f, 0f, 1f);
    }

    public override void ThrowToBlender()
    {
        ActivateFruit(this);
    }
}
