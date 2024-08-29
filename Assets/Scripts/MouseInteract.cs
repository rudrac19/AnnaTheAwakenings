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
    public Rigidbody lockerKeyCollider;

    [Header("Floor Key Settings")]
    public Vector3 newFloorKeyPostion;
    public Vector3 newFloorKeyRotation;
    public Rigidbody floorKeyGravity;
    public MeshCollider floorKeyCollider;

    [Header("Barrel Key Settings")]

    [Header("Safe Key Settings")]

    [Header("Padloack Key Settings")]
    
    [Header("Crowbar Settings")]
    
    [Header("Chest Key Settings")]
    
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
                    //floorKeyCollider.useGravity = false;
                    gameObject.transform.position = newFloorKeyPostion;
                    gameObject.transform.rotation = Quaternion.Euler(newFloorKeyRotation);
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
                    Destroy(gameObject);//subject to change
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
                    Destroy(gameObject);//subject to change
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
                    Destroy(gameObject);//subject to change
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
                    Destroy(gameObject);//subject to change
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
                    Destroy(gameObject);//subject to change
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
