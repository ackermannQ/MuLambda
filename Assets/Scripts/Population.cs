using Assets.Individuals;
using UnityEngine;

public class Population : MonoBehaviour
{
    public GameObject[] rabbits;
    public GameObject[] Initialize(int mu, int lambda)
    {
        var totalPopulation = mu + lambda;
        var individuals = new Rabbit[totalPopulation];

        for (var i = 0; i < totalPopulation; i++)
        {
            individuals[i] = new Rabbit();
        }

        //return Shuffle(individuals);
        return rabbits;
    }

    public Rabbit[] Shuffle(Rabbit[] individuals)
    {
        // Shuffle the individuals to escape loss of gradient
        return individuals;
    }
}