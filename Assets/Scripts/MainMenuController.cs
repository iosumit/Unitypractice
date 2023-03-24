using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        int index = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        GameManager.instance.CharIndex = index;
        if (index == 2)
            SceneManager.LoadScene("FlappyBird");
        else
            SceneManager.LoadScene("Gameplay");
    }
}
