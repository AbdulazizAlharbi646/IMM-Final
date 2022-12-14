using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneResetter : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y < -15)
        {
            GameManager.gameManager.menu.OpenMenuPanel();
        }
    }
}
