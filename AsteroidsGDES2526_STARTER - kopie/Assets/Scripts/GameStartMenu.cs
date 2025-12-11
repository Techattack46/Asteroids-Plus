using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartMenu : MonoBehaviour
{
    public string scene;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
