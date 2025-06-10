using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scanSpaceOutside : MonoBehaviour
{
    [Header("Param�tres de recherche")]
    [Tooltip("Nom exact du GameObject � trouver (ou laissez vide pour utiliser le tag)")]
    public string objectName = "Space Outside";

    // R�f�rence � votre script SeatedControls
    private SeatedControls seatedControls;

    void Awake()
    {
        // On r�cup�re le premier SeatedControls trouv� dans la sc�ne
        seatedControls = FindObjectOfType<SeatedControls>();
        if (seatedControls == null)
            Debug.LogWarning("[SpaceOutsideScanner] Aucun SeatedControls trouv� dans la sc�ne !");
    }

    void Update()
    {
        seatedControls.spaceOutside = GameObject.Find(objectName);
    }
}
