using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anna : MonoBehaviour
{
    public static string annaLocation;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AnnaLocationChange());
    }

    // Update is called once per frame
    void Update()
    {
        if (annaLocation == MouseInteract.floor)
        {
            Debug.Log("ur dead");
        }
    }

    IEnumerator AnnaLocationChange()
    {
        annaLocation = "two";
        float timeToChange = Random.Range(10.0f, 30.0f);

        yield return new WaitForSeconds(timeToChange);

        // give warning
        Debug.Log("Warning");

        float warningTime = Random.Range(5.0f, 15.0f);

        yield return new WaitForSeconds(warningTime);

        annaLocation = "one";

        // repeat for floor one
        timeToChange = Random.Range(10.0f, 30.0f);

        yield return new WaitForSeconds(timeToChange);

        // give warning
        Debug.Log("Warning");

        warningTime = Random.Range(5.0f, 15.0f);

        yield return new WaitForSeconds(warningTime);

        annaLocation = "two";

        StartCoroutine(AnnaLocationChange());
    }
}
