using UnityEngine;

namespace Assets.Individuals
{
    public sealed class Rabbit : Individual
    {
        public void Start()
        {
            speed = Random.Range(0f, 8f);
            genre = (int)Mathf.Ceil(Random.Range(0f, 2f));
        }
        public override float Evaluate()
        {
            return 1f;
        }
    }
}