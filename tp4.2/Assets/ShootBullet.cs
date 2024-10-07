using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // Pour le nouveau syst�me d'entr�e
using UnityEngine.XR.Interaction.Toolkit;

public class ShootBullet : MonoBehaviour
{
    public GameObject projectilePrefab;   // Le projectile � instancier
    public Transform barrelEnd;           // L'endroit d'o� sort le projectile (g�n�ralement le bout du pistolet)
    public float projectileSpeed = 20f;   // Vitesse du projectile
    public XRController controller;       // R�f�rence � la manette XR
    public InputActionReference triggerAction; // Action de la g�chette

    private bool isGrabbed = false;       // Pour v�rifier si l'arme est grab

    private void OnEnable()
    {
        triggerAction.action.performed += OnTriggerPressed;
    }

    private void OnDisable()
    {
        triggerAction.action.performed -= OnTriggerPressed;
    }

    // M�thode appel�e lorsqu'on presse la g�chette
    private void OnTriggerPressed(InputAction.CallbackContext context)
    {
        if (isGrabbed)
        {
            Shoot();
        }
    }

    // M�thode pour tirer le projectile
    void Shoot()
    {
        // Instancie le projectile � la position du bout du pistolet avec son orientation actuelle
        GameObject projectile = Instantiate(projectilePrefab, barrelEnd.position, barrelEnd.rotation);

        // Applique une force au projectile dans la direction o� pointe le pistolet
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = barrelEnd.forward * projectileSpeed;
        }
    }

    // Cette m�thode sera utilis�e pour capturer l'�v�nement de "grab"
    public void Grab()
    {
        isGrabbed = true;
    }

    // Cette m�thode sera utilis�e pour capturer l'�v�nement de "release"
    public void Release()
    {
        isGrabbed = false;
    }
}
