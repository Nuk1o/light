using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenLoader : MonoBehaviour
{
    public void SceneLoad(string _sceneName)
    {
        try
        {
            SceneManager.LoadScene(_sceneName);
        }
        catch
        {
            Debug.Log("Название сцены не указано");
        }
    }
}
