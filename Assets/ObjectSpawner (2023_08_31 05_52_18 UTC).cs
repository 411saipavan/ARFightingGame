using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    private PlacementIndicator placementIndicator;
    public ButtonScript spawnButton;
    // Start is called before the first frame update
    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
        spawnButton = GameObject.FindWithTag("Respawn").GetComponent<ButtonScript>();
        player.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnButton.pressed)
        {
            if (!player.activeInHierarchy)
            {
                player.transform.position = placementIndicator.transform.position;
                player.transform.rotation = player.transform.rotation;
                player.SetActive(true);
            }
            else
            {
                Instantiate(enemy,
                    placementIndicator.transform.position,
                    enemy.transform.rotation);
            }
            spawnButton.pressed = false;
        }
    }
}
