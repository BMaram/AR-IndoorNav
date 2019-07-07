using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class moves : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Test("T1")); 
    }

    IEnumerator Test(string ss) {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(ss);
    }
}
