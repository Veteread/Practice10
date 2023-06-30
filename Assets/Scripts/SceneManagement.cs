using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{   
    public void Scene(int Index)
    {
        SceneManager.LoadScene(Index);
    }   
}
