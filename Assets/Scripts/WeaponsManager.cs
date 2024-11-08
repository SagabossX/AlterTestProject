using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeaponsManager : MonoBehaviour
{
    [SerializeField]
    List<WeaponBase> Guns;

    int currentGunIndex;

    public WeaponBase CurrentGun;

    [SerializeField]
    TMP_Text currentGunTxt;
    private void Start()
    {
        currentGunIndex = -1;
        LoadNextGun();

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadNextGun();
        }
    }

    public void LoadNextGun()
    {
        if (currentGunIndex < Guns.Count-1)
        {
            currentGunIndex++;
        }
        else
        {
            currentGunIndex = 0;
        }
       

        if (CurrentGun != null)
        {
            Destroy(CurrentGun.gameObject);
        }

        switch (currentGunIndex)
        {
            case 0:
                currentGunTxt.text = "Fire Weapon";
                break;
            case 1:
                currentGunTxt.text = "Ice Weapon";
                break;
            case 2:
                currentGunTxt.text = "Electric Weapon";
                break;
            default:
                currentGunTxt.text = "Fire Weapon";
                break;
        }

        CurrentGun= Instantiate(Guns[currentGunIndex]);
    }
    public void Shoot()
    {
        if (CurrentGun == null)
            return;

        CurrentGun.Shoot();
    }
}
