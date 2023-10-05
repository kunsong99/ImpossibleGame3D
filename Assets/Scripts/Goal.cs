using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private IEnumerator OnCollisionEnter(Collision other)
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("WinScene");
    }
}