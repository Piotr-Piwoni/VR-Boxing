using UnityEngine;

namespace Player.AI
{
    public class Fighting : MonoBehaviour
    {
        private float _attackDelay;
        public float setAttackDelay;
        public float randomChance;
        private int _randomPick;
        public bool isBlockingRight = false;
        public bool isAttackingJab = false;
        public bool isBlockingLeft =  false;
        public bool isAttackingHook = false;
        private Animator _animator;

        private void Start()
        {
            randomChance = Random.Range(1f, 3f);
            _animator = GetComponent<Animator>();
        }

        void Update()
        {
            if (_attackDelay > setAttackDelay)
            {
                if (randomChance > 1.5f)
                {
                    isBlockingRight = false;
                    _animator.SetBool("IsBlockingRight", isBlockingRight);

                    Punch();

                    if (_randomPick == 1)
                    {
                        isAttackingHook = true;
                        _animator.SetBool("IsAttackingHook", isAttackingHook);

                        isAttackingJab = false;
                        _animator.SetBool("IsAttackingJab", isAttackingJab);
                    } else
                    {
                        isAttackingHook = false;
                        _animator.SetBool("IsAttackingHook", isAttackingHook);

                        isAttackingJab = false;
                        _animator.SetBool("IsAttackingJab", isAttackingJab);
                    }
                    
                }
                else
                {
                    isAttackingJab = false;
                    _animator.SetBool("IsAttackingJab", isAttackingJab);

                    Block();
                    
                    if (_randomPick == 1)
                    {
                        isBlockingLeft = true;
                        _animator.SetBool("IsBlockingLeft", isBlockingLeft);

                        isBlockingRight = false;
                        _animator.SetBool("IsBlockingRight", isBlockingRight);
                    }
                    else
                    {
                        isBlockingLeft = false;
                        _animator.SetBool("IsBlockingLeft", isBlockingLeft);

                        isBlockingRight = false;
                        _animator.SetBool("IsBlockingRight", isBlockingRight);
                    }
                }

                randomChance = Random.Range(1f, 3f); // This resets the random range
                _attackDelay = 0; //This is the delay reset.
           
            }
            else
            {
                _attackDelay += Time.deltaTime;
            }
        
            _randomPick = Random.Range(0, 2);
        
        }

        private void Punch()
        {
            
            isAttackingJab = true;
            _animator.SetBool("IsAttackingJab", isAttackingJab);
        }

        private void Block()
        {
            isBlockingRight = true;
            _animator.SetBool("IsBlockingRight", isBlockingRight);
        }
    }
}

