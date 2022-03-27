using System.Collections.Generic;
using UnityEngine;

public class Simulation : MonoBehaviour
{
    public Population pop;
    public List<GameObject> individuals;
    void Start()
    {
        var mu = 5;
        var lambda = 3;
        individuals = pop.Initialize(mu, lambda);

        //individuals = individuals.OrderByDescending(i => i.Evaluate()).ToArray();

        foreach (var i in individuals)
        {
            //Debug.Log(i.Evaluate());
            Debug.Log("----------");
        }
    }
}
