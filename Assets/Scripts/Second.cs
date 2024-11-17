using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Second : MonoBehaviour
{
    public AudioSource second;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartVoice");
    }

    IEnumerator StartVoice()
    {
        yield return new WaitForSeconds(2f);
        second.Play();
        yield return new WaitForSeconds(60f);
        SceneManager.LoadScene("Credits");
    }

}
