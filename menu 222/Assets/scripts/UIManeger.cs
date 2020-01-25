using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManeger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Starting()
    {
        SceneManager.LoadScene(1);
    }

    public void Seach()
    {
        SceneManager.LoadScene(2);
    }

    public void Information()
    {
        SceneManager.LoadScene(3);
    }

    public void Exit2()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit3()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit4()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
