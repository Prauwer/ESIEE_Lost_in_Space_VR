using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour
{
    public GameObject objectToPersist;
    public string sceneToLoad; // Le nom de la sc�ne � charger

    void Start()
    {
        if (objectToPersist != null)
        {
            DontDestroyOnLoad(objectToPersist);
        }
        else
        {
            Debug.LogError("Aucun objet � rendre persistant n'a �t� assign�.");
        }

        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("Aucune sc�ne � charger n'a �t� sp�cifi�e.");
        }
        string currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;

        Debug.Log("HELLO, nous sommes dans " + currentScene);
    }

    void Update()
    {
        // Votre logique de mise � jour ici
    }
}
