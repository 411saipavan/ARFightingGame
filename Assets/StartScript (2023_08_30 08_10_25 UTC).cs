using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
     public Button start_Button;
    // Start is called before the first frame update
    void Awake()
    {
        start_Button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        NewMethod();
    }

    private void NewMethod()
    {
        start_Button.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        PlayerPrefs.SetInt("Score", 0);
        SceneManager.LoadScene("SampleScene");
    }
}
