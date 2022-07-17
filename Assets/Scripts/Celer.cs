using UnityEngine;

public class Celer : Fruit
{
    private void Awake()
    {
        FruitColor = new Color(0f, 0.5f, 0f, 1f);
    }

    public override void ThrowToBlender()
    {
        ActivateFruit(this);
    }
}
