using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public string animalName { get; private set; }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MonkeyPosess()
    {
        animalName = "Monkey";
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(1);
    }

    public void OctopusPosess()
    {
        animalName = "Octopus";
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(1);
        Debug.Log("Scene1 Loaded");
      
       
    }
}
