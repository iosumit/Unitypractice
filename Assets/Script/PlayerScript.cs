using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    void Start()
    {
        // Debug.Log("");
        // Debug.Log(speed);
        // print(speed);
        // StartCoroutine(ExecuteSomething());
        Warrior warrior = new Warrior(100, 90, "Legends");
        warrior.Health = 20;
        warrior.info();
        warrior.Attack();
    }

    IEnumerator ExecuteSomething()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("Coroutine Executed");
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 pos = transform.position;
        pos.x += speed * h * Time.deltaTime;
        pos.y += speed * v * Time.deltaTime;
        transform.position = pos;
    }
}
