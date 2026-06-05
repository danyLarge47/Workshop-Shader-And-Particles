using System.Collections.Generic;
using UnityEngine;

public class ParticleListener_Emitter : MonoBehaviour
{

    public ParticleSystem ps  ;
    
    void OnParticleTrigger()
    {
        List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();
        int count = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
    
        for (int i = 0; i < count; i++)
        {
            ParticleSystem.Particle p = enter[i];
            p.startColor = Color.red; // modify individual particle
            enter[i] = p;
        }
        ps.SetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
    }
}
