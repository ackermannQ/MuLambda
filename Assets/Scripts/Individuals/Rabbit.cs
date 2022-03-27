using UnityEngine;

namespace Assets.Individuals
{
    public sealed class Rabbit : Individual
    {
        public float randomRotation = 0f;

        public GameObject prefab;

        private GameObject target;

        public void Start()
        {
            transform.position = new Vector3(transform.position.x + Random.Range(-12f, 12f), transform.position.y, transform.position.z + Random.Range(-5f, 3f));

            speed = Random.Range(0f, 8f);
            genre = (int)Mathf.Ceil(Random.Range(0f, 2f));
            fitScore = speed / 8f;
            currentSpeed = speed;

            CreateTarget();
        }

        public void Update()
        {
            Roaming();
        }

        public override float Evaluate()
        {
            return fitScore;
        }

        public override void Roaming()
        {
            float step = currentSpeed * Time.deltaTime / 5f;
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);

            if (Vector3.Distance(transform.position, target.transform.position) < 0.001f)
            {
                // Change the target target.transform.position -= new Vector3(1f, 0f, -1f);
                target.transform.position += new Vector3(0f, 0f, 1f);
            }
        }

        private void CreateTarget()
        {
            target = Instantiate(prefab, transform.position + 2 * transform.forward, new Quaternion(0f, 0f, 0f, 1));
            target.GetComponent<MeshRenderer>().enabled = false;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("StopTrigger"))
            {
                Stop();
            }
        }

        private void Stop()
        {
            currentSpeed = 0f;
        }
    }
}