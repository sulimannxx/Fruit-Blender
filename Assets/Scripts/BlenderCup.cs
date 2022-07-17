using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlenderCup : MonoBehaviour
{
    private List<Fruit> _fruitsInBlender = new List<Fruit>();

    private IEnumerator ShakeBlender(Fruit fruit)
    {
        float timer = 0f;
        Rigidbody fruitRigidbody = fruit.GetComponent<Rigidbody>();

        while (timer <= 5f)
        {
            fruitRigidbody.AddTorque(Random.Range(2f, 14f), Random.Range(2f, 14f), Random.Range(2f, 14f), ForceMode.Force);
            timer += Time.deltaTime;
            yield return null;
        }
    }

    public void AddFruitToBlender(Fruit fruit)
    {
        _fruitsInBlender.Add(fruit);
    }

    public void Shake()
    {
        foreach (var fruit in _fruitsInBlender)
        {
            StartCoroutine(ShakeBlender(fruit));
        }
    }
}
