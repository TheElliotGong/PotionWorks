using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static AudioManager instance;
    [SerializeField] private AudioSource audio;
    [SerializeField] private List<AudioClip> music;
    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
            
    }

    void Start()
    {
        audio.clip = music[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetAudio(int index)
    {
        audio.clip = music[index];
        audio.PlayDelayed(0.75f);
    }
}
