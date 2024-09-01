using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteract : MonoBehaviour
{

    public float offsetDistance;

    public GameObject[] uIS;

    [Header("Player Settings")]
    public GameObject player;
    public Vector3 playerRotation;

    [Header("Locker Key Settings")]
    public Vector3 newLockerKeyPostion;
    public Vector3 newLockerKeyRotation;
    public Rigidbody lockerKeyGravity;
    public MeshCollider lockerKeyCollider;

    [Header("Floor Key Settings")]
    public Vector3 newFloorKeyPostion;
    public Vector3 newFloorKeyRotation;
    public Rigidbody floorKeyGravity;
    public MeshCollider floorKeyCollider;

    [Header("Barrel Key Settings")]
    public Vector3 newBarrelKeyPostion;
    public Vector3 newBarrelKeyRotation;
    public Rigidbody barrelKeyGravity;
    public MeshCollider barrelKeyCollider;

    [Header("Safe Key Settings")]
    public Vector3 newSafeKeyPostion;
    public Vector3 newSafeKeyRotation;
    public Rigidbody safeKeyGravity;
    public MeshCollider safeKeyCollider;
    
    [Header("Padloack Key Settings")]
    public Vector3 newPadlockKeyPostion;
    public Vector3 newPadlockKeyRotation;
    public Rigidbody padlockKeyGravity;
    public MeshCollider padlockKeyCollider;

    [Header("Crowbar Settings")]
    public Vector3 newCrowbarPostion;
    public Vector3 newCrowbarRotation;
    public Rigidbody crowbarGravity;
    public MeshCollider crowbarCollider;

    [Header("Chest Key Settings")]
    public Vector3 newChestKeyPostion;
    public Vector3 newChestKeyRotation;
    public Rigidbody chestKeyGravity;
    public MeshCollider chestKeyCollider;

    [Header("Red Key Settings")]
    public Rigidbody redKeyGravity;
    public MeshCollider redKeyCollider;

    [Header("Blue Key Settings")]
    public Rigidbody blueKeyGravity;
    public MeshCollider blueKeyCollider;

    [Header("Black Key Settings")]
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
                    GameObject gameObject = hit.collider.gameObject;
                    lockerKeyGravity.useGravity = false;
                    lockerKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotation);
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
                    GameObject gameObject = hit.collider.gameObject;
                    floorKeyGravity.useGravity = false;
                    floorKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotation);
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
                    GameObject gameObject = hit.collider.gameObject;
                    barrelKeyGravity.useGravity = false;
                    barrelKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotation);
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
                    GameObject gameObject = hit.collider.gameObject;
                    safeKeyGravity.useGravity = false;
                    safeKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotation);
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
                    GameObject gameObject = hit.collider.gameObject;
                    padlockKeyGravity.useGravity = false;
                    padlockKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotation);
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
                    GameObject gameObject = hit.collider.gameObject;
                    crowbarGravity.useGravity = false;
                    crowbarCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotation);
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
                    GameObject gameObject = hit.collider.gameObject;
                    chestKeyGravity.useGravity = false;
                    chestKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotation);
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
                    GameObject gameObject = hit.collider.gameObject;
                    redKeyGravity.useGravity = false;
                    redKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotation);
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
                    GameObject gameObject = hit.collider.gameObject;
                    blueKeyGravity.useGravity = false;
                    blueKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotation);
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
                    GameObject gameObject = hit.collider.gameObject;
                    blackKeyGravity.useGravity = false;
                    blackKeyCollider.enabled = false;
                    player.transform.rotation = Quaternion.Euler(playerRotation);
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
                uIS[0].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    GameObject gameObject = hit.collider.gameObject;
                    uIS[0].SetActive(true);
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
    }
}
