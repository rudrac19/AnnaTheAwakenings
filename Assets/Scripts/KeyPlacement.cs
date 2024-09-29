
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPlacement : MonoBehaviour
{
    public GameObject[] keys;

    // Crowbar, Black Key, Red Key, Blue Key are not listed cuz they are fixed positions
    int locationOfLockerKey; // Locker Key -- Barrel Key
    int locationOfFloorKey;// Floor Key -- Chest Key
    int locationOfBarrelKey;// Locker Key -- Barrel Key
    public int locationOfSafeKey;// Safe Key -- Padlock Key
    int locationOfPadlockKey;// Safe Key -- Padlock Key
    int locationOfChestKey;// Floor Key -- Chest Key


    public Vector3 lockerKeyPositionOnDrawer;
    public Vector3 lockerKeyPositionOnDesk;
    public Vector3 floorKeyPositionOnLivingRoomTable;
    public Vector3 floorKeyPositionInLocker;
    public Vector3 barrelKeyPositionOnDrawer;
    public Vector3 barrelKeyPositionOnDesk;
    public Vector3 safeKeyPositionOnKitchenCounter;
    public Vector3 safeKeyPositionInBarrel;
    public Vector3 padlockKeyPositionOnKitchenCounter;
    public Vector3 padlockKeyPositionInBarrel;
    public Vector3 chestKeyPositionOnLivingRoomTable;
    public Vector3 chestKeyPositionInLocker;


    void Start()
    {
        DeterminePositionOfKeys();
        PlaceTheKeys();
    }

    void DeterminePositionOfKeys()
    {

        // Locker Key -- Barrel Key
        locationOfLockerKey = Random.Range(0, 2);
        if (locationOfLockerKey == 0)
        {
            locationOfBarrelKey = 1;
        }
        else if (locationOfLockerKey == 1)
        {
            locationOfBarrelKey = 0;
        }
        // Floor Key -- Chest Key
        locationOfFloorKey = Random.Range(0, 2);
        if (locationOfFloorKey == 0)
        {
            locationOfChestKey = 1;
        }
        else if (locationOfFloorKey == 1)
        {
            locationOfChestKey = 0;
        }

        // Safe Key -- Padlock Key
        locationOfSafeKey = Random.Range(0, 2);
        if (locationOfSafeKey == 0)
        {
            locationOfPadlockKey = 1;
        }
        else if (locationOfSafeKey == 1)
        {
            locationOfPadlockKey = 0;
        }
    }

    void PlaceTheKeys()
    {
        // Locker Key -- Barrel Key

        if (locationOfLockerKey == 0)
        {
            keys[0].transform.localPosition = lockerKeyPositionOnDrawer;
            keys[2].transform.localPosition = barrelKeyPositionOnDesk;
        }
        else if (locationOfLockerKey == 1)
        {
            keys[0].transform.localPosition = lockerKeyPositionOnDesk;
            keys[2].transform.localPosition = barrelKeyPositionOnDrawer;
        }

        // FLoor Key -- Chest Key

        if (locationOfFloorKey == 0)
        {
            keys[1].transform.localPosition = floorKeyPositionOnLivingRoomTable;
            keys[5].transform.localPosition = chestKeyPositionInLocker;
        }
        else if (locationOfFloorKey == 1)
        {
            keys[1].transform.localPosition = floorKeyPositionInLocker;
            keys[5].transform.localPosition = chestKeyPositionOnLivingRoomTable;
        }

        // Safe Key -- Padlock Key

        if (locationOfSafeKey == 0)
        {
            keys[3].transform.localPosition = safeKeyPositionOnKitchenCounter;
            keys[3].gameObject.SetActive(true);
            keys[4].transform.localPosition = padlockKeyPositionInBarrel;
        }
        else if (locationOfSafeKey == 1)
        {
            keys[3].transform.localPosition = safeKeyPositionInBarrel;
            keys[4].gameObject.SetActive(true);
            keys[4].transform.localPosition = padlockKeyPositionOnKitchenCounter;
        }
    }
}
