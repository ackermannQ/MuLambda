﻿using UnityEngine;

namespace Assets.Individuals
{
    public class Individual : MonoBehaviour, IIndividual
    {
        public float speed;
        public int genre;
        public float fitScore;

        public virtual float Evaluate()
        {
            return 1f;
        }
        public virtual void Roaming()
        {
            Debug.Log("Roaming like an individual (not a rabbit nor a wolf ... For now!");
        }
    }
}
