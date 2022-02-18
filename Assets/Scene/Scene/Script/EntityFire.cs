using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityFire : MonoBehaviour
{
    [SerializeField] Transform _spawnPoint;
    //[SerializeField] Bullet _bulletPrefab;
    [SerializeField] BulletPool _bulletPool; //Pool de Bullet

    [SerializeField] bool canShoot = true;

    public void FireBullet(int power)
    {
        if (canShoot)
        {
            //var b = Instantiate(_bulletPrefab, _spawnPoint.transform.position, Quaternion.identity, null)
            //    .Init(_spawnPoint.TransformDirection(Vector3.right), power);

            var b = _bulletPool.GetPooledObject(); // Récupère un objet disponible de la pool
            if (b != null)
            {
                b.transform.position = _spawnPoint.position;
                b.GetComponent<Bullet>().Init(_spawnPoint.TransformDirection(Vector3.right), power);
                b.SetActive(true);
            }
        }
    }

    //Active ou Désactive le shoot (Shield)
    public void CanShoot(bool state)
    {
        canShoot = state;
    }

}
