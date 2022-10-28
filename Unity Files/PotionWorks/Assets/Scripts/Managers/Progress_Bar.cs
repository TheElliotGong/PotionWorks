using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Progress_Bar : MonoBehaviour
{
    // Start is called before the first frame update
    private Slider slider;
    private ParticleSystem particles;
    public float fillSpeed = 0.08f;
    public float progress = 0;
    public float maxValue;
    void Start()
    {
        
        
    }
    private void Awake()
    {
        
        progress = 0;
        slider = gameObject.GetComponent<Slider>();
        particles = gameObject.GetComponentInChildren<ParticleSystem>();
        slider.maxValue = maxValue;
    }
    // Update is called once per frame
    void Update()
    {
        if(slider.value < progress)
        {
            slider.value += fillSpeed * Time.deltaTime;
            if (!particles.isPlaying)
                particles.Play();
        }
        else
        {
            particles.Stop();
        }
    }

    public void AddProgress(float newProgress)
    {
        progress = slider.value += newProgress;
    }
}
