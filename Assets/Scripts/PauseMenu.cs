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
    public bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
       
        GameManager.Instance.UnPauseMusic();
        menu.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {//The second you press the button the frame is activated
        if (Input.GetKeyDown(TestingKey))
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

        if (Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
    }
        public void TogglePauseGame()
        {
            //Will only open menu
            //menu.SetActive(true)
            isPaused = !isPaused;
            //menu.SetActive(!menu.activeInHierarchy);
            menu.SetActive(isPaused);
            //! reverts the statement to make it false on it's next implementation
            
            if (isPaused)
            {
                Time.timeScale = 0f;
            //a class that refers to a specific gamescene variable
            // GameManager.Instance.audio.pitch = 0f;
            GameManager.Instance.PauseMusic();
            }
            else
            {
                Time.timeScale = 1f;
            //GameManager.Instance.audio.pitch = 1f;
            GameManager.Instance.UnPauseMusic();
            }
        }
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void PlaySound(AudioClip clip)
    {
        GameManager.Instance.audio.PlayOneShot(clip);
    }

    }

   
