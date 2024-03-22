using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange1 : MonoBehaviour
{
    public void ChangeScene ()
    {
        SceneManager.LoadScene(0);
    }
}
