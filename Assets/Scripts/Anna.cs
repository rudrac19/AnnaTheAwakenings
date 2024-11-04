using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Anna : MonoBehaviour
{
    public static string annaLocation;
    public string playerLocation;
    

    // Start is called before the first frame update
    void Start()
    {
        annaLocation = "two";
        StartCoroutine(AnnaLocationChange());
    }

    // Update is called once per frame
    void Update()
    {
        playerLocation = MouseInteract.floor;
        if (annaLocation == MouseInteract.floor)
        {
            Debug.Log("ur dead");
        }
    }

    IEnumerator AnnaLocationChange()
    {
        annaLocation = "two";
        if (annaLocation == MouseInteract.floor)
        {
            SceneManager.LoadScene("You Won");
        }
        float timeToChange = Random.Range(10.0f, 30.0f);

        yield return new WaitForSeconds(timeToChange);

        // give warning
        Debug.Log("Warning");
        annaLocation = "warning";

        float warningTime = Random.Range(5.0f, 15.0f);

        yield return new WaitForSeconds(warningTime);

        annaLocation = "one";
        if (annaLocation == MouseInteract.floor)
        {
            SceneManager.LoadScene("You Won");
        }

        // repeat for floor one
        timeToChange = Random.Range(10.0f, 30.0f);

        yield return new WaitForSeconds(timeToChange);

        // give warning
        Debug.Log("Warning");
        annaLocation = "warning";

        warningTime = Random.Range(5.0f, 15.0f);

        yield return new WaitForSeconds(warningTime);

        annaLocation = "two";
        if (annaLocation == MouseInteract.floor)
        {
            SceneManager.LoadScene("You Won");
        }
        StartCoroutine(AnnaLocationChange());
    }
}
