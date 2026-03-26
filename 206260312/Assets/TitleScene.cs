using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    public void ButtonLog()
    {
        Debug.Log("BUTTON CLICKED!");
    }
    public GameObject ScenePanel;

    public void GameStart()
    {
        SceneManager.LoadScene("TitleScene");
    }
    public void OpenScene()
    {
        ScenePanel.SetActive(true);
    }
    public void CloseScene()
    {
        ScenePanel.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
