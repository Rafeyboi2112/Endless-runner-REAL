using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScreen : MonoBehaviour
{
    public void LoadControls()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
