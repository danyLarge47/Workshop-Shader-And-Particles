using System.Collections.Generic;
using UnityEngine;

public class ParticleListener_Hit : MonoBehaviour
{
    
    
    void OnParticleCollision(GameObject other)
    {
        // 'other' is the particle system GameObject that hit this object
        ParticleSystem ps = other.GetComponent<ParticleSystem>();
        List<ParticleCollisionEvent> events = new List<ParticleCollisionEvent>();
        int count = ParticlePhysicsExtensions.GetCollisionEvents(ps, gameObject, events);
    
        for (int i = 0; i < count; i++)
        {
            Vector3 hitPoint = events[i].intersection;
            Vector3 hitNormal = events[i].normal;
            // spawn hit VFX, apply damage, etc
            Debug.Log($"{name} get hit by {ps.name} at {hitPoint} with {hitNormal}");
        }
    }
    
}
