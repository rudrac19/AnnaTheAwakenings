using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteract : MonoBehaviour
{

    public float offsetDistance;
    public string holding = "";
    public GameObject keys;

    public GameObject[] uIS;

    [Header("Player Settings")]
    public GameObject player;
    public Vector3 playerRotationWhenHavingAKey;
    public Vector3 playerRotationInFirstFloor;
    public Vector3 playerRotationInSecondFloor;
    public Vector3 playerPositionInFirstFloor;
    public Vector3 playerPositionInSecondFloor;

    [Header("Locker Key Settings")]
    public GameObject lockerKey;
    public Vector3 newLockerKeyPostion;
    public Vector3 newLockerKeyRotation;
    public Rigidbody lockerKeyGravity;
    public MeshCollider lockerKeyCollider;

    [Header("Floor Key Settings")]
    public GameObject floorKey;
    public Vector3 newFloorKeyPostion;
    public Vector3 newFloorKeyRotation;
    public Rigidbody floorKeyGravity;
    public MeshCollider floorKeyCollider;

    [Header("Barrel Key Settings")]
    public GameObject barrelKey;
    public Vector3 newBarrelKeyPostion;
    public Vector3 newBarrelKeyRotation;
    public Rigidbody barrelKeyGravity;
    public MeshCollider barrelKeyCollider;

    [Header("Safe Key Settings")]
    public GameObject safeKey;
    public Vector3 newSafeKeyPostion;
    public Vector3 newSafeKeyRotation;
    public Rigidbody safeKeyGravity;
    public MeshCollider safeKeyCollider;
    
    [Header("Padloack Key Settings")]
    public GameObject padlockKey;
    public Vector3 newPadlockKeyPostion;
    public Vector3 newPadlockKeyRotation;
    public Rigidbody padlockKeyGravity;
    public MeshCollider padlockKeyCollider;

    [Header("Crowbar Settings")]
    public GameObject crowbar;
    public Vector3 newCrowbarPostion;
    public Vector3 newCrowbarRotation;
    public Rigidbody crowbarGravity;
    public MeshCollider crowbarCollider;

    [Header("Chest Key Settings")]
    public GameObject chestKey;
    public Vector3 newChestKeyPostion;
    public Vector3 newChestKeyRotation;
    public Rigidbody chestKeyGravity;
    public MeshCollider chestKeyCollider;

    [Header("Red Key Settings")]
    public GameObject redKey;
    public Rigidbody redKeyGravity;
    public MeshCollider redKeyCollider;

    [Header("Blue Key Settings")]
    public GameObject blueKey;
    public Rigidbody blueKeyGravity;
    public MeshCollider blueKeyCollider;

    [Header("Black Key Settings")]
    public GameObject blackKey;
    public Rigidbody blackKeyGravity;
    public MeshCollider blackKeyCollider;

    void Start()
    {
        foreach (GameObject uI in uIS)
        {
            uI.SetActive(false);
        }
        uIS[0].SetActive(true);
    }
    
    void Update()
    {
        Vector3 rayDirection = transform.forward;
        Vector3 rayOrigin = transform.position + rayDirection.normalized * offsetDistance;
        float rayDistance = 1f;

        Debug.DrawRay(rayOrigin, rayDirection * 10, Color.red);

        RaycastHit hit;

        if (Physics.Raycast(rayOrigin, rayDirection, out hit, rayDistance))
        {
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
            }

            if (hit.collider.gameObject.name == "Locker Key")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[1].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    holding = "Locker Key";
                    GameObject gameObject = hit.collider.gameObject;
                    lockerKeyGravity.useGravity = false;
                    lockerKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotationWhenHavingAKey);
                    gameObject.transform.SetParent(player.transform);
                    gameObject.transform.localPosition = Vector3.zero;
                    gameObject.transform.localPosition = newLockerKeyPostion;
                    gameObject.transform.rotation = Quaternion.Euler(newLockerKeyRotation);

                }
            }
            else if (hit.collider.gameObject.name == "Floor Key")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[2].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    holding = "Floor Key";
                    GameObject gameObject = hit.collider.gameObject;
                    floorKeyGravity.useGravity = false;
                    floorKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotationWhenHavingAKey);
                    gameObject.transform.SetParent(player.transform);
                    gameObject.transform.localPosition = Vector3.zero;
                    gameObject.transform.localPosition = newFloorKeyPostion;
                    gameObject.transform.rotation = Quaternion.Euler(newFloorKeyRotation);
                    
                }
            }
            else if (hit.collider.gameObject.name == "Barrel Key")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[3].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    holding = "Barrel Key";
                    GameObject gameObject = hit.collider.gameObject;
                    barrelKeyGravity.useGravity = false;
                    barrelKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotationWhenHavingAKey);
                    gameObject.transform.SetParent(player.transform);
                    gameObject.transform.localPosition = Vector3.zero;
                    gameObject.transform.localPosition = newBarrelKeyPostion;
                    gameObject.transform.rotation = Quaternion.Euler(newBarrelKeyRotation);
                }
            }
            else if (hit.collider.gameObject.name == "Safe Key")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[4].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    holding = "Safe Key";
                    GameObject gameObject = hit.collider.gameObject;
                    safeKeyGravity.useGravity = false;
                    safeKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotationWhenHavingAKey);
                    gameObject.transform.SetParent(player.transform);
                    gameObject.transform.localPosition = Vector3.zero;
                    gameObject.transform.localPosition = newSafeKeyPostion;
                    gameObject.transform.rotation = Quaternion.Euler(newSafeKeyRotation);
                }
            }
            else if (hit.collider.gameObject.name == "Padlock Key")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[5].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    holding = "Padlock Key";
                    GameObject gameObject = hit.collider.gameObject;
                    padlockKeyGravity.useGravity = false;
                    padlockKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotationWhenHavingAKey);
                    gameObject.transform.SetParent(player.transform);
                    gameObject.transform.localPosition = Vector3.zero;
                    gameObject.transform.localPosition = newPadlockKeyPostion;
                    gameObject.transform.rotation = Quaternion.Euler(newPadlockKeyRotation);
                }
            }
            else if (hit.collider.gameObject.name == "Crowbar")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[6].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    holding = "Crowbar";
                    GameObject gameObject = hit.collider.gameObject;
                    crowbarGravity.useGravity = false;
                    crowbarCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotationWhenHavingAKey);
                    gameObject.transform.SetParent(player.transform);
                    gameObject.transform.localPosition = Vector3.zero;
                    gameObject.transform.localPosition = newCrowbarPostion;
                    gameObject.transform.rotation = Quaternion.Euler(newCrowbarRotation);
                }
            }
            else if (hit.collider.gameObject.name == "Chest Key")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[7].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    holding = "Chest Key";
                    GameObject gameObject = hit.collider.gameObject;
                    chestKeyGravity.useGravity = false;
                    chestKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotationWhenHavingAKey);
                    gameObject.transform.SetParent(player.transform);
                    gameObject.transform.localPosition = Vector3.zero;
                    gameObject.transform.localPosition = newChestKeyPostion;
                    gameObject.transform.rotation = Quaternion.Euler(newChestKeyRotation);
                }
            }
            else if (hit.collider.gameObject.name == "Red Key")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[8].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    holding = "Red Key";
                    GameObject gameObject = hit.collider.gameObject;
                    redKeyGravity.useGravity = false;
                    redKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotationWhenHavingAKey);
                    gameObject.transform.SetParent(player.transform);
                    gameObject.transform.localPosition = Vector3.zero;
                    gameObject.transform.localPosition = newFloorKeyPostion;
                    gameObject.transform.rotation = Quaternion.Euler(newFloorKeyRotation);
                }
            }
            else if (hit.collider.gameObject.name == "Blue Key")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[9].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    holding = "Blue Key";
                    GameObject gameObject = hit.collider.gameObject;
                    blueKeyGravity.useGravity = false;
                    blueKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotationWhenHavingAKey);
                    gameObject.transform.SetParent(player.transform);
                    gameObject.transform.localPosition = Vector3.zero;
                    gameObject.transform.localPosition = newFloorKeyPostion;
                    gameObject.transform.rotation = Quaternion.Euler(newFloorKeyRotation);
                }
            }
            else if (hit.collider.gameObject.name == "Black Key")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[10].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    holding = "Black Key";
                    GameObject gameObject = hit.collider.gameObject;
                    blackKeyGravity.useGravity = false;
                    blackKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotationWhenHavingAKey);
                    gameObject.transform.SetParent(player.transform);
                    gameObject.transform.localPosition = Vector3.zero;
                    gameObject.transform.localPosition = newFloorKeyPostion;
                    gameObject.transform.rotation = Quaternion.Euler(newFloorKeyRotation);
                }
            }
            else if (hit.collider.gameObject.name == "Floor 2 Door")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[11].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    GameObject gameObject = hit.collider.gameObject;
                    player.transform.position = playerPositionInSecondFloor;
                    player.transform.rotation = Quaternion.Euler(playerRotationInSecondFloor);
                }
            }
            else if (hit.collider.gameObject.name == "Chest")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[0].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    GameObject gameObject = hit.collider.gameObject;
                    uIS[0].SetActive(true);
                }
            }
            else if (hit.collider.gameObject.name == "Barrels")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[0].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    GameObject gameObject = hit.collider.gameObject;
                    uIS[0].SetActive(true);
                }
            }
            else
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[0].SetActive(true);
            }
        }

        if (holding != "")
        {
            if (holding == "Locker Key" && Input.GetButtonDown("Jump")) // "Jump" equals to Drop
            {
                lockerKey.transform.SetParent(keys.transform);
                lockerKeyGravity.useGravity = true;
                lockerKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Floor Key" && Input.GetButtonDown("Jump"))
            {
                floorKey.transform.SetParent(keys.transform);
                floorKeyGravity.useGravity = true;
                floorKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Barrel Key" && Input.GetButtonDown("Jump"))
            {
                barrelKey.transform.SetParent(keys.transform);
                barrelKeyGravity.useGravity = true;
                barrelKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Safe Key" && Input.GetButtonDown("Jump"))
            {
                safeKey.transform.SetParent(keys.transform);
                safeKeyGravity.useGravity = true;
                safeKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Padlock Key" && Input.GetButtonDown("Jump"))
            {
                padlockKey.transform.SetParent(keys.transform);
                padlockKeyGravity.useGravity = true;
                padlockKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Crowbar" && Input.GetButtonDown("Jump"))
            {
                crowbar.transform.SetParent(keys.transform);
                crowbarGravity.useGravity = true;
                crowbarCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Chest Key" && Input.GetButtonDown("Jump"))
            {
                chestKey.transform.SetParent(keys.transform);
                chestKeyGravity.useGravity = true;
                chestKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Red Key" && Input.GetButtonDown("Jump"))
            {
                redKey.transform.SetParent(keys.transform);
                redKeyGravity.useGravity = true;
                redKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Blue Key" && Input.GetButtonDown("Jump"))
            {
                blueKey.transform.SetParent(keys.transform);
                blueKeyGravity.useGravity = true;
                blueKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Black Key" && Input.GetButtonDown("Jump"))
            {
                blackKey.transform.SetParent(keys.transform);
                blackKeyGravity.useGravity = true;
                blackKeyCollider.enabled = true;
                holding = "";
            }
        }
    }
}
