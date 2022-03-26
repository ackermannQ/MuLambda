using UnityEngine;

namespace Assets.Individuals
{
    public class Individual : MonoBehaviour, IIndividual
    {
        public float speed;
        public int genre;

        public virtual float Evaluate()
        {
            return 1f;
        }
    }
}
