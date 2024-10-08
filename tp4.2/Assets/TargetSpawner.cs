using UnityEngine;
using System.Collections;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;  // Le prefab de la cible
    public float spawnInterval = 5f;  // Intervalle de temps entre chaque spawn
    public Vector3 spawnAreaMin;  // Limite minimum de l'aire de spawn
    public Vector3 spawnAreaMax;  // Limite maximum de l'aire de spawn

    private void Start()
    {
        // Lancer la coroutine qui spawn les cibles
        StartCoroutine(SpawnTargetsCoroutine());
    }

    // Coroutine pour générer des cibles à intervalles réguliers
    IEnumerator SpawnTargetsCoroutine()
    {
        while (true)
        {
            SpawnTarget();
            yield return new WaitForSeconds(spawnInterval);  // Attendre avant de spawner une nouvelle cible
        }
    }

    // Fonction de génération d'une cible
    void SpawnTarget()
    {
        Vector3 randomPosition = new Vector3(
            (int)Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            (int)Random.Range(spawnAreaMin.y, spawnAreaMax.y),
            (int)Random.Range(spawnAreaMin.z, spawnAreaMax.z)
        );

        Instantiate(targetPrefab, randomPosition, Quaternion.identity);  // Générer une nouvelle cible
    }
}
