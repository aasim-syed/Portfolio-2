using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    private int flag = 0;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Cube1")
        {
            if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                if(flag==0)
                    SceneManager.LoadSceneAsync("About", LoadSceneMode.Additive);
                flag++;
            }
        }
        if (other.gameObject.tag == "Cube2")
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                if (flag == 0)
                    SceneManager.LoadSceneAsync("Education", LoadSceneMode.Additive);
                flag++;
            }
        }
        if (other.gameObject.tag == "Cube3")
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                if (flag == 0)
                    SceneManager.LoadSceneAsync("Achievements", LoadSceneMode.Additive);
                flag++;
            }
        }
        if (other.gameObject.tag == "Cube4")
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                if (flag == 0)
                    SceneManager.LoadSceneAsync("Skills", LoadSceneMode.Additive);
                flag++;
            }
        }
        if (other.gameObject.tag == "Cube5")
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                if (flag == 0)
                    SceneManager.LoadSceneAsync("Projects", LoadSceneMode.Additive);
                flag++;
            }
        }
        if (other.gameObject.tag == "Cube6")
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                if (flag == 0)
                    SceneManager.LoadSceneAsync("Experience", LoadSceneMode.Additive);
                flag++;
            }
        }
        if (other.gameObject.tag == "Cube7")
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                if (flag == 0)
                    Application.OpenURL("https://www.linkedin.com/in/pranshi112/");
                flag++;
            }
        }
        if (other.gameObject.tag == "Cube8")
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                if (flag == 0)
                    Application.OpenURL("https://github.com/pranshi112");
                flag++;
            }
        }
        if (other.gameObject.tag == "Cube9")
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                if (flag == 0)
                    Application.OpenURL("mailto:apranshi11@gmail.com");
                flag++;
            }
        }
        if (other.gameObject.tag == "Cube10")
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                if (flag == 0)
                    Application.OpenURL("https://medium.com/@pranshi112");
                flag++;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        flag = 0;
    }
}
