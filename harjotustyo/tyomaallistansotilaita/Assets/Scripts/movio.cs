using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnituEngine.SceneManagement;
public class movio : MonoBehaviour
{
    public float waitT = 43f;
    void Start()
    {
        StartCoroutine(oovio());
    }

    IEnumerator oovio()
    {
          yield return new WaitForSeconds(waitT);  


            SceneManager.LoadScene(1);
    }
}
