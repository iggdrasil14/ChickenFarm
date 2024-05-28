using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void GameStart()     //Метод запуска приложения.
    {
        SceneManager.LoadScene(1);
    }

    public void SceneLoadGame()  //Метод загрузки сохраненной игры.
    {
        //SceneManager.LoadScene();
        Debug.Log("Загрузка сохраненной игры");
    }

    public void SceneOptions()  //Метод запуска экрана опции/настройки.
    {
        //SceneManager.LoadScene();
        Debug.Log("Запуск сцены Options");
    }

    public void SceneCredits()  //Метод запуска экрана кредиты.
    {
        //SceneManager.LoadScene();
        Debug.Log("Запуск сцены Credits");
    }

    public void ExitGame()      //Метод выхода из приложения.
    {
        Application.Quit();
    }

}
