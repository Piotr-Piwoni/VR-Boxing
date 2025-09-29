using UnityEngine;

namespace Player.AI
{
    public abstract class State: MonoBehaviour
    {
        public abstract State RunCurrentState();
    }
}
