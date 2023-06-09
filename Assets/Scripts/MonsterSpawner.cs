using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterRefrence;
    private GameObject spawnedMonster;
    private int randomIndex;
    private int randomSide;

    [SerializeField]
    private Transform leftPos, rightPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnedMonsters());
    }

    IEnumerator SpawnedMonsters()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            randomIndex = Random.Range(0, monsterRefrence.Length);
            randomSide = Random.Range(0, 2);
            spawnedMonster = Instantiate(monsterRefrence[randomIndex]);

            // left side
            if (randomSide == 0)
            {
                spawnedMonster.transform.position = leftPos.position;
                spawnedMonster.GetComponent<Monster>().speed = Random.Range(4, 10);
            }
            else
            {
                // right side
                spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
                spawnedMonster.transform.position = rightPos.position;
                spawnedMonster.GetComponent<Monster>().speed = -Random.Range(4, 10);
            }
        }
    }
}
