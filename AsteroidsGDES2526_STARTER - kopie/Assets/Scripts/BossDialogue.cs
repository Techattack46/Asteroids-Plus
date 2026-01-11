using UnityEngine;

[CreateAssetMenu(fileName = "NewBossDialogue", menuName = "Boss Dialogue")]
public class BossDialogue : ScriptableObject
{
    public string bossName;
    public Sprite bossPortrait;
    public string[] dialogueLines;
    public bool[] autoProgressLines;
    public float autoProgressDelay = 1.5f;
    public float typingSpeed = 0.05f;
}
