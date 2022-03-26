using UnityEngine;

namespace Assets.Individuals
{
    public sealed class Wolf : Individual
    {
        public void Start()
        {
            speed = Random.Range(3f, 5f);
            genre = (int)Mathf.Ceil(Random.Range(0f, 2f));
        }
        public override float Evaluate()
        {
            return 1f;
        }
    }
}