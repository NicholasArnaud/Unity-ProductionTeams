using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStartOnClick : MonoBehaviour
{
    public void LoadCombatScene()
    {
        SceneManager.LoadScene(1);
    }

}
