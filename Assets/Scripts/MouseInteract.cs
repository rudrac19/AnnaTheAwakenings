using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteract : MonoBehaviour
{

    public float offsetDistance;

    public GameObject[] uIS;
    
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
                    GameObject key = hit.collider.gameObject;
                    Destroy(key);
                }
            }
            else if (hit.collider.gameObject.name == "Chest Key")
            {
                foreach (GameObject uI in uIS)
                {
                    uI.SetActive(false);
                }
                uIS[2].SetActive(true);

                if (Input.GetButtonDown("Intereact"))
                {
                    GameObject key = hit.collider.gameObject;
                    Destroy(key);
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
