using UnityEngine;

namespace Assets.Individuals
{
    public sealed class Rabbit : Individual
    {
        public void Start()
        {
            transform.position = new Vector3(transform.position.x + Random.Range(0f, 12f), transform.position.y, transform.position.z + Random.Range(0f, 5f));
            speed = Random.Range(0f, 8f);
            genre = (int)Mathf.Ceil(Random.Range(0f, 2f));
            fitScore = speed / 8f;
        }
        public override float Evaluate()
        {
            return 1f;
        }

        public override void Roaming()
        {
            // Spawn a cylinder to look at somewhere in a circle around the rabbit
            // Move toward with the speed (can't be realistic, but just for now)

            Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cylinder), transform);
        }
    }
}