using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public Animator anna;
    public AudioSource attack;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        attack.Play();
        anna.SetTrigger("Attack");
        yield return new WaitForSeconds(8f);
        SceneManager.LoadScene("Home");
    }
}
