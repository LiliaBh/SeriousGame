using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStart : MonoBehaviour
{
    public void ChangeScene(string sceneName) {
        Application.LoadLevel(sceneName);
    }
}
