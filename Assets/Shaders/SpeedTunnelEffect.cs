using UnityEngine;

[ExecuteInEditMode]
public class SpeedTunnelEffect : MonoBehaviour
{
    public Material tunnelMaterial; // Mat�riel avec le shader
    public Rigidbody spaceshipRigidbody; // R�f�rence au Rigidbody du vaisseau
    public float blurMultiplier = 0.1f; // Facteur de multiplication pour le flou
    public float maxBlur = 5.0f; // Valeur maximale du flou

    private float currentBlurStrength;

    void Update()
    {
        if (spaceshipRigidbody != null && tunnelMaterial != null)
        {
            // Calculer la vitesse du vaisseau
            float speed = spaceshipRigidbody.velocity.magnitude;

            // Calculer l'intensit� du flou proportionnellement � la vitesse
            currentBlurStrength = Mathf.Clamp(speed * blurMultiplier, 0, maxBlur);

            // Appliquer l'intensit� du flou au shader
            tunnelMaterial.SetFloat("_BlurStrength", currentBlurStrength);
        }
    }

    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if (tunnelMaterial != null)
        {
            Graphics.Blit(src, dest, tunnelMaterial);
        }
        else
        {
            Graphics.Blit(src, dest);
        }
    }
}