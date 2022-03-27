using System.Collections.Generic;
using UnityEngine;

public class Population : MonoBehaviour
{
    public GameObject rabbitPrefab;

    public List<GameObject> rabbits;

    public List<GameObject> Initialize(int mu, int lambda)
    {
        var totalPopulation = mu + lambda;

        for (var i = 0; i < totalPopulation; i++)
        {
            rabbits.Add(Instantiate(rabbitPrefab));
        }

        return Shuffle(rabbits);
    }

    public List<GameObject> Shuffle(List<GameObject> individuals)
    {
        // Shuffle the individuals to escape loss of gradient
        return individuals;
    }
}