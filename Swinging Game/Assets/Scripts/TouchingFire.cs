using UnityEngine;
using UnityEngine.SceneManagement;
public class TouchingFire : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("test");
        //Destroy(gameObject);
        gameObject.active = false;
        SceneManager.LoadScene(2);
    }
}