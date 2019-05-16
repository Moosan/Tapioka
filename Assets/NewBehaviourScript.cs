using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject obj;
    private void Awake()
    {
        Time.timeScale = 1f;
    }
    private void Start()
    {
        StartCoroutine(tapioka());
    }
    IEnumerator tapioka()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.3f);
            Instantiate(obj, transform.position, transform.rotation);
        }
    }
}
