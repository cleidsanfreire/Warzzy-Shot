using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefabs;
    private Rigidbody2D rig;

    private Vector2 timeIntervalSpawn = new Vector2(1, 1);

    Vector2 originPoint = new Vector2(0f,0f);


    private float cooldown;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        cooldown = Random.Range(timeIntervalSpawn.x, timeIntervalSpawn.y);


    }

    // Update is called once per frame
    void Update()
    {
        GameManager gameManager = GameManager.Instance;
        cooldown -= Time.deltaTime;
        if (gameManager.isGameActive)
        {
            if (cooldown <= 0)
            {
                cooldown = Random.Range(timeIntervalSpawn.x, timeIntervalSpawn.y);
                Spawn();
            }
        }
    }

    void Spawn()
    {
        int prefabIndex = Random.Range(0, prefabs.Count);
        GameObject spwanPrefab = prefabs[prefabIndex];

        float gameWidth = GameManager.Instance.gameWidth;
        float xOffset = Random.Range(-gameWidth /2f , gameWidth / 2f);
        float yOffset = transform.position.y;
        Vector2 position = originPoint + new Vector2(xOffset, yOffset);

        GameObject enemy = Instantiate(spwanPrefab, position, transform.rotation);
    }
}
