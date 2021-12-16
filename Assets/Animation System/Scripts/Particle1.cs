using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle1 : MonoBehaviour
{
    private ParticleSystem ps;

    float value1, value2;
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(StartParticle());
        }
        
    }

    IEnumerator StartParticle()
    {
        yield return new WaitForEndOfFrame();
        var particleNoise = ps.noise;
        particleNoise.enabled = true;
        particleNoise.strength = value1;
        particleNoise.frequency = value2;
        particleNoise.octaveCount = 2;
        value1 = Random.Range(1, 5);
        value2 = Random.Range(0, 3);
        ps.Play();

        yield return new WaitForSeconds(5f);
        ps.Stop();
    }
}
