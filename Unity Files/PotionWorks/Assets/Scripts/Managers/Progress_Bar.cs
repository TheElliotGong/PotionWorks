using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Progress_Bar : MonoBehaviour
{
    // Start is called before the first frame update
    private Slider slider;
    private ParticleSystem particles;
    private float fillSpeed = 20f;
    public float progress;
    public float maxValue;
    void Start()
    {
        
    }
    private void Awake()
    {
       
        slider = gameObject.GetComponent<Slider>();
        particles = gameObject.GetComponentInChildren<ParticleSystem>();
        particles.Play();
        progress = 0;
        slider.maxValue = maxValue;
    }
    // Update is called once per frame
    void Update()
    {
        if(slider.value < progress)
            slider.value += fillSpeed * Time.deltaTime;


    }

    public void AddProgress(float newProgress)
    {
        progress = slider.value + newProgress;
    }
}
