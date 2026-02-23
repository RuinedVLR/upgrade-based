using UnityEngine;
using UnityEngine.SceneManagement;

public class UIContorller : MonoBehaviour
{
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("Hub");
    }
}
