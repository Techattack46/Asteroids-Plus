using UnityEngine;
using UnityEngine.SceneManagement;

public class ExpositionMenu : MonoBehaviour
{
    public string scene;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
