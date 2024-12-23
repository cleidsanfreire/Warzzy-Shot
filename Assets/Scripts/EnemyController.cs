using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float _lifeHealth;
    [SerializeField] private float _currentLife;
    [SerializeField] private float cooldown = 1;


    [SerializeField] private float speed;
    [SerializeField] private float limit;

    private Rigidbody2D rig;

    public float lifeHealth { get => _lifeHealth; set => _lifeHealth = value; }
    public float currentLife { get => _currentLife; set => _currentLife = value; }

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        currentLife = lifeHealth;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        cooldown -= Time.deltaTime;
        if (transform.position.y < limit || currentLife <= 0 || cooldown <= 0)
        { 
            Destroy(gameObject);
        }

        if (transform.position.y < limit && GameManager.Instance.loseEnemy < 3)
        {
            GameManager.Instance.loseEnemy++;
        }
    }
}
