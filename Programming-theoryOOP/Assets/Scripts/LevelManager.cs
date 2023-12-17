using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var GameManager = GameObject.FindAnyObjectByType<GameManager>();
        if (GameManager != null)
        {
            if (GameManager.animalName=="Octopus")
            {
                var monkey = GameObject.FindAnyObjectByType<Monkey>();
                Debug.Log(monkey);
                Destroy(monkey);
                Debug.Log("Octopus mode");
            }
            else
            {
                
                var octopus = GameObject.FindAnyObjectByType<Octopus>();
                Debug.Log("Monkey mode");
                Debug.Log(octopus);
                octopus.GetComponentInChildren<Camera>().enabled = false;
                Destroy(octopus);
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
