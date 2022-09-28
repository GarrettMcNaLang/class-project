using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject menu;
    public TextMeshProUGUI testingText;
    public KeyCode TestingKey;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {//The second you press the button the frame is activated
        if(Input.GetKeyDown(TestingKey))
        {
            testingText.text = "Down";
            testingText.color = Color.red;
          //Debug.Log("Down");
        }
        else if (Input.GetKey(TestingKey))
        {
            testingText.text = "Hold";
            testingText.color = Color.magenta;
          //Debug.Log("Hold");
        }
        else if (Input.GetKeyUp(TestingKey))
        {
            testingText.text = "Up";
            testingText.color = Color.yellow;
            //
          //Debug.Log("Up");
        }
        else
        {
            //nothing as this would be every frame the key is not pressed
        }

        if(Input.GetButtonDown("Cancel"))
        {
            //Will only open menu
            //menu.SetActive(true)
            menu.SetActive(!menu.activeInHierarchy);//! reverts the statement to make it false on it's next implementation
        }
    }

    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
