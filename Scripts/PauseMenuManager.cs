using UnityEngine;
using UnityEngine.Events;


public class PauseMenuManager : MonoBehaviour   // Класс PauseMenuManager управляет меню паузы в игре [1]
{
    public GameObject pauseMenuUI;              // Объект UI для меню паузы [2]
    public UnityEvent OnGamePaused;             // Событие, которое вызывается при паузе игры [9]
    public UnityEvent OnGameResumed;            // Событие, которое вызывается при возобновлении игры [10]
    private bool isPaused = false;              // Переменная, которая отслеживает, находится ли игра на паузе [7]
        
    private void Start()
    {
        OnGameResumed.Invoke();                 // Этот метод вызывается при запуске сцены и вызывает событие возобновления игры [8]
    }
        
    void Update()                               // Этот метод вызывается каждый кадр и проверяет нажатие кнопки Escape для управления паузой игры [3]
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
    public void ContinueGame()                  // Этот метод возобновляет игру, отключает меню паузы и восстанавливает обычную скорость времени [4]
    {
        Debug.Log("Продолжение игры...");
    }

    public void SaveGame()                      // Этот метод сохраняет игру, отключает меню паузы и восстанавливает обычную скорость времени [4]
    {
        Debug.Log("Сохранение игры...");
    }

    public void OptionsGame()                   // Этот метод открывает настройки игры
    {
        Debug.Log("Опции игры...");
    }

    public void ResumeGame()                    // Этот метод возобновляет игру, отключает меню паузы и восстанавливает обычную скорость времени [4]
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        OnGameResumed.Invoke();
    }

    public void PauseGame()                     // Этот метод ставит игру на паузу, активирует меню паузы и устанавливает скорость времени на 0 [5]
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        OnGamePaused.Invoke();
    }
        
    public void QuitGame()                      // Этот метод вызывает выход из игры [11]
    {
        Application.Quit();
    }
}