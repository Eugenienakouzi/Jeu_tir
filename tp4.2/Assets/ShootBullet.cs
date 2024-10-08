using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    public float bulletSpeed = 20f;

    public void FireBullet()
    {
        GameObject spawnedBullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        spawnedBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * bulletSpeed, ForceMode.Impulse);
        Destroy(spawnedBullet, 5f);
    }
}
