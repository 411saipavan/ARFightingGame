using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReplayScript : MonoBehaviour
{
    public Button replay_Button;
    // Start is called before the first frame update
    void Start()
    {
        replay_Button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        replay_Button.onClick.AddListener(ReplayGame);
    }
    void ReplayGame()
    {
        PlayerPrefs.SetInt("Score", 0);
        SceneManager.LoadScene("SampleScene");
    }
}
