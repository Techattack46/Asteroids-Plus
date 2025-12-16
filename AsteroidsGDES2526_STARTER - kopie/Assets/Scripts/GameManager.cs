using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    public int score;
    public static int finalScore;
    public TextMeshProUGUI scoreboard;
    public bool itemEquipped = false;

    public TextMeshProUGUI equipTextMesh;
    public string equipText;
    public string fizzleText;
    public float equipDuration;
    public AudioClip equipSound;
    public AudioClip fizzleSound;

    public bool bossMayEnter = false;
    public bool bossHasSpawned = false;

    private void Awake()
    {
        equipTextMesh = GameObject.FindWithTag("UI Event")?.GetComponent<TextMeshProUGUI>();

        if (instance != null)
            Destroy(instance.gameObject);
        instance = this;
    }

    private void Start()
    {
        scoreboard.text = score.ToString();
        score = 0;
    }

    private void Update()
    {
        scoreboard.text = score.ToString();
    }

    public void ItemEquip()
    {
        AudioManager.Instance.PlayClip(equipSound);

        equipTextMesh.text = equipText;

        itemEquipped = true;

        Invoke(nameof(ItemFizzle), equipDuration);
    }

    private void ItemFizzle()
    {
        AudioManager.Instance.PlayClip(fizzleSound);
        
        equipTextMesh.text = fizzleText;

        itemEquipped = false;
    }
}
