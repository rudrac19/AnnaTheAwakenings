using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class Anna : MonoBehaviour
{
    public static string annaLocation;
    public string playerLocation;
    public AudioSource safeArea;
    public AudioSource annaComing;

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
            SceneManager.LoadScene("You Won");
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
        safeArea.volume = 0.0f;
        annaComing.Play();

        float warningTime = Random.Range(5.0f, 15.0f);
        yield return new WaitForSeconds(warningTime);

        annaComing.Stop();
        safeArea.volume = 1.0f;
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
        safeArea.volume = 0.0f;
        annaComing.Play();

        warningTime = Random.Range(5.0f, 15.0f);
        yield return new WaitForSeconds(warningTime);

        annaComing.Stop();
        safeArea.volume = 1.0f;
        annaLocation = "two";
        if (annaLocation == MouseInteract.floor)
        {
            SceneManager.LoadScene("You Won");
        }
        StartCoroutine(AnnaLocationChange());
    }

    
}
