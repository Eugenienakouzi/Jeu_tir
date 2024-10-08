using UnityEngine;

public class Target : MonoBehaviour
{
    public ParticleSystem hitEffect;  // Effet de particules � d�clencher

    private void Update()
    {
        Destroy(gameObject,10f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")  // V�rifie si l'objet touchant est une balle
        {
            //Instantiate(hitEffect, transform.position, Quaternion.identity);  // Cr�e l'effet de particules
            Destroy(gameObject);  // D�truit la cible
        }
    }
}

