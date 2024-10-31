using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void Change_scene(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }
}


