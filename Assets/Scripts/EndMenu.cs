using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenu : MonoBehaviour
{
    public void Quit()
    {
        // Can not see when pre-running, need to build first
        Application.Quit();
    }
}
