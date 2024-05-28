using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void GameStart()     //����� ������� ����������.
    {
        SceneManager.LoadScene(1);
    }

    public void SceneLoadGame()  //����� �������� ����������� ����.
    {
        //SceneManager.LoadScene();
        Debug.Log("�������� ����������� ����");
    }

    public void SceneOptions()  //����� ������� ������ �����/���������.
    {
        //SceneManager.LoadScene();
        Debug.Log("������ ����� Options");
    }

    public void SceneCredits()  //����� ������� ������ �������.
    {
        //SceneManager.LoadScene();
        Debug.Log("������ ����� Credits");
    }

    public void ExitGame()      //����� ������ �� ����������.
    {
        Application.Quit();
    }

}
