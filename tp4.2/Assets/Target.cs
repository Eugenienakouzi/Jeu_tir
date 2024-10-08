using UnityEngine;

public class Target : MonoBehaviour
{
    public ParticleSystem hitEffect;  // Effet de particules à déclencher

    private void Update()
    {
        Destroy(gameObject,10f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")  // Vérifie si l'objet touchant est une balle
        {
            //Instantiate(hitEffect, transform.position, Quaternion.identity);  // Crée l'effet de particules
            Destroy(gameObject);  // Détruit la cible
        }
    }
}

