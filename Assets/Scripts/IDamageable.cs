using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SI
{
    public interface IDamageable<T>
    {
        void Damage(T damageTaken);
    }
}