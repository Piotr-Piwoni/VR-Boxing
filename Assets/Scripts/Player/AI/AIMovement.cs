using UnityEngine;
using UnityEngine.AI;

namespace AI
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class AIMovement: MonoBehaviour
    {
        private NavMeshAgent navMeshAgent;
        public Transform playerTransform;
        
        private void Start()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            var position = playerTransform.position;
            Vector3 playerPosition = new Vector3(position.x, position.y,position.z);
            
            navMeshAgent.destination = playerPosition;
            
            transform.LookAt(playerTransform);
        }
    }
}