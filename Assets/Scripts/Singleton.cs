using UnityEngine;
using UnityEngine.SceneManagement;

public class Singleton : MonoBehaviour
{
    // Instance Singleton
    private static Singleton _instance;
    // Exemple de donn�e persistant


    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            // Ne pas d�truire ce GameObject au chargement d'une nouvelle sc�ne
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Un autre Singleton existe d�j� : on supprime ce doublon
            Destroy(gameObject);
        }
    }


    void Start()
    {
    }

    void Update()
    {
    }
}