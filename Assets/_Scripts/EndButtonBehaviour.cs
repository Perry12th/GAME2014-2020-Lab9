using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButtonBehaviour : MonoBehaviour
{
    public void OnEndButtonPressed()
    {
        SceneManager.LoadScene("Platformer");
    }
}
