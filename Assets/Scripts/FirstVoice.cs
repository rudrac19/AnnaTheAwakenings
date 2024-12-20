using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FirstVoice : MonoBehaviour
{
    public AudioSource recordingOne;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartVoice");
    }

    IEnumerator StartVoice()
    {
        yield return new WaitForSeconds(2f);
        recordingOne.Play();
        yield return new WaitForSeconds(60f);
        SceneManager.LoadScene("SampleScene"); 
    }
}
