using UnityEngine;

//Copied from Rosa's
public class AudioManager : MonoBehaviour
{
    public AudioClip[] levelMusic;
    [SerializeField] private AudioSource soundEffectSource;
    [SerializeField] private AudioSource levelMusicSource;

    private static AudioManager instance;
    public static AudioManager Instance { get { return instance; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayLevelMusicIndex(0);
    }

    public void PlayLevelMusicIndex(int index)
    {
        levelMusicSource.clip = levelMusic[index];
        levelMusicSource.Play();
    }
    
    public void PlayClip(AudioClip clip)
    {
        AudioSource source = Instantiate(soundEffectSource);

        source.clip = clip;
        source.volume = 1f;

        source.Play();

        DontDestroyOnLoad(source);

        Destroy(source.gameObject, clip.length);
    }
}
