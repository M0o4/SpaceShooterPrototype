using System;
using UnityEngine;

namespace Entity
{
   public class ExplosionParticle : MonoBehaviour
   {
      private PoolObject.PoolObject _poolObject;
      private ParticleSystem _particle;

      private void Start()
      {
         _poolObject = GetComponent<PoolObject.PoolObject>();
         _particle = GetComponent<ParticleSystem>();
      }

      private void Update()
      {
         if(_particle.isStopped)
            _poolObject.ReturnToPool();
      }
   }
}
