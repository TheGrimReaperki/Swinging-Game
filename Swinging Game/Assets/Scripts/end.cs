using UnityEngine;
using UnityEngine.SceneManagement;
public class end : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("test");
        //SceneManager.LoadScene(3);
    }
}