using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseInteract : MonoBehaviour
{

    public float offsetDistance;
    public string holding = "";
    public GameObject keys;
    public GameObject chestOpened;
    public GameObject chestClosed;
    public GameObject correctBarrel;
    public GameObject wrongBarrel;
    public GameObject brokenBarrel;
    public GameObject safe;
    public GameObject lever;
    public KeyPlacement keyPlacement;
    public Animator animator;
    public static string floor;

    public GameObject[] cantPickUpUI;
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

    [Header("Unlocked/Locked")]
    public bool isFloor2Unlocked = false;
    public bool isChestUnlocked = false;
    public int isDoorUnlocked = 0; // 3 means opened
    public bool isBarrelUnlocked = false;
    public bool isSafeUnlocked = false;
    public bool isLeverUnlocked = false;
    public bool redUnlocked = false;
    public bool blueUnlocked = false;
    public bool blackUnlocked = false;


    void Start()
    {
        foreach (GameObject uI in uIS)
        {
            uI.SetActive(false);
        }
        uIS[0].SetActive(true);
        floor = "one";
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
                //Debug.Log(hit.collider.gameObject.name);
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
                    if (holding == "")
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
                    else 
                    {
                        StartCoroutine(CantPickUpText(1));
                    }

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
                    if ( holding == "")
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
                    else
                    {
                        StartCoroutine(CantPickUpText(2));
                    }

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
                    if( holding == "")
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
                    else
                    {
                        StartCoroutine(CantPickUpText(3));
                    }
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
                    if ( holding == "")
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
                    else
                    {
                        StartCoroutine(CantPickUpText(4));
                    }
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
                    if (holding == "")
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
                    else
                    {
                        StartCoroutine(CantPickUpText(4));
                    }
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
                    if (holding == "")
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
                    else
                    {
                        StartCoroutine(CantPickUpText(5));
                    }
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
                    if ( holding == "")
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
                    else
                    {
                        StartCoroutine(CantPickUpText(6));
                    }
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
                    if( holding == "")
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
                    else
                    {
                        StartCoroutine(CantPickUpText(7));
                    }
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
                    if (holding == "")
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
                    else
                    {
                        StartCoroutine(CantPickUpText(8));
                    } 
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
                    if ( holding == "")
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
                    else
                    {
                        StartCoroutine(CantPickUpText(9));
                    }
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
                    if (holding == "Floor Key" && !isFloor2Unlocked)
                    {
                        GameObject gameObject = hit.collider.gameObject;
                        player.transform.position = playerPositionInSecondFloor;
                        player.transform.rotation = Quaternion.Euler(playerRotationInSecondFloor);
                        isFloor2Unlocked = true;
                        floor = "two";
                    }
                    else if (isFloor2Unlocked)
                    {
                        GameObject gameObject = hit.collider.gameObject;
                        player.transform.position = playerPositionInSecondFloor;
                        player.transform.rotation = Quaternion.Euler(playerRotationInSecondFloor);
                        floor = "two";
                    }
                }
            }
            else if (hit.collider.gameObject.name == "Floor 1 Door")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[12].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    GameObject gameObject = hit.collider.gameObject;
                    player.transform.position = playerPositionInFirstFloor;
                    player.transform.rotation = Quaternion.Euler(playerRotationInFirstFloor);
                    floor = "one";
                }
            }
            else if (hit.collider.gameObject.name == "chest_close")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[13].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    if (holding == "Chest Key" && !isChestUnlocked)
                    {
                        GameObject gameObject = hit.collider.gameObject;
                        gameObject.SetActive(false);
                        chestOpened.SetActive(true);
                        blackKey.SetActive(true);
                        isChestUnlocked = true;
                    }
                }
            }
            else if (hit.collider.gameObject.name == "Door Opener")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[14].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    if (holding == "Black Key" )
                    {
                        blackUnlocked = true;
                    }
                    if (holding == "Blue Key")
                    {
                        blueUnlocked = true;    
                    }
                    if (holding == "Red Key")
                    {
                        redUnlocked = true;
                    }
                    if (redUnlocked && blueUnlocked && blackUnlocked)
                    {
                        SceneManager.LoadScene("Credits");
                    }
                }
            }
            else if (hit.collider.gameObject.name == "Correct Barrel")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[15].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    if (holding == "Barrel Key" && !isBarrelUnlocked)
                    {   
                        correctBarrel.SetActive(false);
                        brokenBarrel.SetActive(true);
                        Debug.Log(keyPlacement.locationOfSafeKey.ToString());
                        if (keyPlacement.locationOfSafeKey == 0)
                        {
                            padlockKey.SetActive(true);
                        }
                        else if (keyPlacement.locationOfSafeKey == 1)
                        {
                            safeKey.SetActive(true);
                        }
                    }
                }
            }
            else if (hit.collider.gameObject.name == "Safe")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[16].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    if (holding == "Safe Key" && !isSafeUnlocked)
                    {
                        safe.SetActive(false);
                        blueKey.SetActive(true);
                        isSafeUnlocked = true;
                    }
                }
            }
            else if (hit.collider.gameObject.name == "Whole Lever")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[17].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    if (holding == "Padlock Key" && !isLeverUnlocked)
                    {
                        StartCoroutine(Go());
                        isLeverUnlocked = true;
                    }
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

    IEnumerator CantPickUpText(int itemIndex)
    {
        for (int i = 0; i < cantPickUpUI.Length; i++)
        {
            cantPickUpUI[i].SetActive(false);
        }
        cantPickUpUI[itemIndex].SetActive(true);
        yield return new WaitForSeconds(3f);
        cantPickUpUI[itemIndex].SetActive(false);
    }

    IEnumerator Go()
    {
        animator.SetTrigger("Go");
        yield return new WaitForSeconds(1.5f);
        redKeyGravity.useGravity = true;
        redKeyCollider.enabled = true;
    }

    public void Drop()
    {
        if (holding != "")
        {
            if (holding == "Locker Key")
            {
                lockerKey.transform.SetParent(keys.transform);
                lockerKeyGravity.useGravity = true;
                lockerKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Floor Key")
            {
                floorKey.transform.SetParent(keys.transform);
                floorKeyGravity.useGravity = true;
                floorKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Barrel Key")
            {
                barrelKey.transform.SetParent(keys.transform);
                barrelKeyGravity.useGravity = true;
                barrelKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Safe Key" )
            {
                safeKey.transform.SetParent(keys.transform);
                safeKeyGravity.useGravity = true;
                safeKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Padlock Key")
            {
                padlockKey.transform.SetParent(keys.transform);
                padlockKeyGravity.useGravity = true;
                padlockKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Crowbar" )
            {
                crowbar.transform.SetParent(keys.transform);
                crowbarGravity.useGravity = true;
                crowbarCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Chest Key" )
            {
                chestKey.transform.SetParent(keys.transform);
                chestKeyGravity.useGravity = true;
                chestKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Red Key" )
            {
                redKey.transform.SetParent(keys.transform);
                redKeyGravity.useGravity = true;
                redKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Blue Key" )
            {
                blueKey.transform.SetParent(keys.transform);
                blueKeyGravity.useGravity = true;
                blueKeyCollider.enabled = true;
                holding = "";
            }
            else if (holding == "Black Key" )
            {
                blackKey.transform.SetParent(keys.transform);
                blackKeyGravity.useGravity = true;
                blackKeyCollider.enabled = true;
                holding = "";
            }
        }
    }

}
