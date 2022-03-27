using Assets.Individuals;
using System.Collections.Generic;
using UnityEngine;

public class Simulation : MonoBehaviour
{
    public int mu = 5;
    public int lambda = 3;

    public Population pop;
    public List<GameObject> individuals;
    public List<float> fitScore;
    void Start()
    {
        individuals = pop.Initialize(mu, lambda);

        //individuals = individuals.OrderByDescending(i => i.Evaluate()).ToArray();

        foreach (var i in individuals)
        {
            Debug.Log(i.gameObject.GetComponent<Rabbit>().currentSpeed);
            fitScore.Add(i.GetComponent<Rabbit>().Evaluate());
        }
    }
}
