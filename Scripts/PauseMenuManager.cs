using UnityEngine;
using UnityEngine.Events;


public class PauseMenuManager : MonoBehaviour   // ����� PauseMenuManager ��������� ���� ����� � ���� [1]
{
    public GameObject pauseMenuUI;              // ������ UI ��� ���� ����� [2]
    public UnityEvent OnGamePaused;             // �������, ������� ���������� ��� ����� ���� [9]
    public UnityEvent OnGameResumed;            // �������, ������� ���������� ��� ������������� ���� [10]
    private bool isPaused = false;              // ����������, ������� �����������, ��������� �� ���� �� ����� [7]
        
    private void Start()
    {
        OnGameResumed.Invoke();                 // ���� ����� ���������� ��� ������� ����� � �������� ������� ������������� ���� [8]
    }
        
    void Update()                               // ���� ����� ���������� ������ ���� � ��������� ������� ������ Escape ��� ���������� ������ ���� [3]
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void ContinueGame()                  // ���� ����� ������������ ����, ��������� ���� ����� � ��������������� ������� �������� ������� [4]
    {
        Debug.Log("����������� ����...");
    }

    public void SaveGame()                      // ���� ����� ��������� ����, ��������� ���� ����� � ��������������� ������� �������� ������� [4]
    {
        Debug.Log("���������� ����...");
    }

    public void OptionsGame()                   // ���� ����� ��������� ��������� ����
    {
        Debug.Log("����� ����...");
    }

    public void ResumeGame()                    // ���� ����� ������������ ����, ��������� ���� ����� � ��������������� ������� �������� ������� [4]
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        OnGameResumed.Invoke();
    }

    public void PauseGame()                     // ���� ����� ������ ���� �� �����, ���������� ���� ����� � ������������� �������� ������� �� 0 [5]
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        OnGamePaused.Invoke();
    }
        
    public void QuitGame()                      // ���� ����� �������� ����� �� ���� [11]
    {
        Application.Quit();
    }
}