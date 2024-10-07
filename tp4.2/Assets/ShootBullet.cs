using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // Pour le nouveau système d'entrée
using UnityEngine.XR.Interaction.Toolkit;

public class ShootBullet : MonoBehaviour
{
    public GameObject projectilePrefab;   // Le projectile à instancier
    public Transform barrelEnd;           // L'endroit d'où sort le projectile (généralement le bout du pistolet)
    public float projectileSpeed = 20f;   // Vitesse du projectile
    public XRController controller;       // Référence à la manette XR
    public InputActionReference triggerAction; // Action de la gâchette

    private bool isGrabbed = false;       // Pour vérifier si l'arme est grab

    private void OnEnable()
    {
        triggerAction.action.performed += OnTriggerPressed;
    }

    private void OnDisable()
    {
        triggerAction.action.performed -= OnTriggerPressed;
    }

    // Méthode appelée lorsqu'on presse la gâchette
    private void OnTriggerPressed(InputAction.CallbackContext context)
    {
        if (isGrabbed)
        {
            Shoot();
        }
    }

    // Méthode pour tirer le projectile
    void Shoot()
    {
        // Instancie le projectile à la position du bout du pistolet avec son orientation actuelle
        GameObject projectile = Instantiate(projectilePrefab, barrelEnd.position, barrelEnd.rotation);

        // Applique une force au projectile dans la direction où pointe le pistolet
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = barrelEnd.forward * projectileSpeed;
        }
    }

    // Cette méthode sera utilisée pour capturer l'événement de "grab"
    public void Grab()
    {
        isGrabbed = true;
    }

    // Cette méthode sera utilisée pour capturer l'événement de "release"
    public void Release()
    {
        isGrabbed = false;
    }
}
