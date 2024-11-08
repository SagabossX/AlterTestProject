using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour
{
    [SerializeField]
    Transform bulletStartPos;

    [SerializeField]
    GameObject Bullet;

    public float Speed;

    private List<GameObject> spawnedBullets=new List<GameObject>();
    public virtual void Shoot()
    {
        SpawnBullet();
    }

    void SpawnBullet()
    {
        GameObject  go= Instantiate(Bullet, bulletStartPos.position,bulletStartPos.localRotation);
        StartCoroutine(MoveBullet(go.transform));
        spawnedBullets.Add(go);
    }

    IEnumerator MoveBullet(Transform bulletTransform)
    {
        float x = 0;

        while (x < 5)
        {
            x += Time.deltaTime;

            bulletTransform.position += bulletTransform.forward * Time.deltaTime * Speed;

            yield return null;
        }

        spawnedBullets.Remove(bulletTransform.gameObject);
        Destroy(bulletTransform.gameObject);
    }

    private void OnDestroy()
    {
        foreach (GameObject go in spawnedBullets) 
        {
          Destroy(go);
        }
    }
}
