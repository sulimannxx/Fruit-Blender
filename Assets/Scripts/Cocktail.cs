using System;
using UnityEngine;

public class Cocktail : MonoBehaviour
{
    private float colorR;
    private float colorG;
    private float colorB;
    private float _ingridientsAmountR;
    private float _ingridientsAmountG;
    private float _ingridientsAmountB;
    public Color CurrentColor { get; private set; } = new Color(0f, 0, 0f, 0f);

    public void AddFruitToCocktail(Color color)
    {
        colorR += color.r;
        colorG += color.g;
        colorB += color.b;

        if (color.r is not 0f or float.NaN || float.IsInfinity(color.r))
        {
            _ingridientsAmountR++;
        }

        if (color.g is not 0f or float.NaN || float.IsInfinity(color.g))
        {
            _ingridientsAmountG++;
        }

        if (color.b is not 0f or float.NaN || float.IsInfinity(color.b))
        {
            _ingridientsAmountB++;
        }
    }

    public void MixCocktail()
    {
        colorR /= _ingridientsAmountR;

        if (_ingridientsAmountR == 0)
        {
            colorR = 0f;
        }

        colorG /= _ingridientsAmountG;

        if (_ingridientsAmountG == 0)
        {
            colorG = 0f;
        }

        colorB /= _ingridientsAmountB;

        if (_ingridientsAmountB == 0)
        {
            colorB = 0f;
        }

        CurrentColor = new Color(colorR, colorG, colorB, 1f);
    }

    public void ResetCocktail()
    {
        _ingridientsAmountR = 0;
        _ingridientsAmountG = 0;
        _ingridientsAmountB = 0;
        colorR = 0;
        colorG = 0;
        colorB = 0;
        CurrentColor = new Color(0f, 0f, 0f, 1f);
    }
}
