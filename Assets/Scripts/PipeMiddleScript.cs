using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicManager logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 7)
            logic.addScore(1);
    }

}
