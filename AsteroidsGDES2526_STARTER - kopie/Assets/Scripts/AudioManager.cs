using UnityEngine;

//Rosa's
public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource sourcePrefab;

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

    public void PlayClip(AudioClip clip)
    {
        AudioSource source = Instantiate(sourcePrefab);

        source.clip = clip;
        source.volume = 1f;

        source.Play();

        DontDestroyOnLoad(source);

        Destroy(source.gameObject, clip.length);
    }
}
