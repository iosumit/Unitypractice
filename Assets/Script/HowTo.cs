using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowTo : MonoBehaviour
{
    // 1st
    private void Awake()
    {
        Debug.Log("1st");
    }
    // 2nd
    private void OnEnable()
    {
        Debug.Log("2nd");
    }
    // 3rd
    // Start is called before the first frame update
    private Rigidbody2D myBody;
    AudioSource audioSource;
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        Debug.Log("Rigid Body : " + myBody.mass);
        StartCoroutine(ss());
    }
    IEnumerator ss()
    {
        yield return new WaitForSeconds(1f);
        myBody.mass = 0.2f;
        myBody.gravityScale = 0.1f;
        audioSource.Play();
        transform.position = new Vector3(10, 20, 30);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
