using UnityEngine;

[ExecuteInEditMode]
public class DynamicFOV : MonoBehaviour
{
    public Camera mainCamera; // R�f�rence � la cam�ra principale
    public Rigidbody spaceshipRigidbody; // R�f�rence au Rigidbody du vaisseau
    public float baseFOV = 60f; // FOV de base (valeur au repos)
    public float maxFOV = 90f; // FOV maximum (valeur � vitesse max)
    public float speedForMaxFOV = 50f; // Vitesse � laquelle le FOV atteint sa valeur max
    public float fovSmoothness = 5f; // Vitesse de transition entre les FOV

    private float targetFOV; // FOV calcul� en fonction de la vitesse

    void Update()
    {
        if (mainCamera != null && spaceshipRigidbody != null)
        {
            // R�cup�rer la vitesse du vaisseau
            float speed = spaceshipRigidbody.velocity.magnitude;

            // Calculer le FOV cible en fonction de la vitesse
            targetFOV = Mathf.Lerp(baseFOV, maxFOV, speed / speedForMaxFOV);

            // Lisser la transition entre le FOV actuel et le FOV cible
            mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView, targetFOV, Time.deltaTime * fovSmoothness);
        }
    }
}
