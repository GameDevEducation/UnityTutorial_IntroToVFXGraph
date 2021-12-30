using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFXDemo : MonoBehaviour
{
    [SerializeField] VisualEffect LinkedEffect;
    [SerializeField] float ParticleScale = 1f;

    float LastParticleScale = -1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LastParticleScale != ParticleScale)
        {
            LastParticleScale = ParticleScale;

            LinkedEffect.SetFloat("Particle Scale", ParticleScale);
        }
    }
}
