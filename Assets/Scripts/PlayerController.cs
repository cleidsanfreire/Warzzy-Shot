using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Vector3 _direcion;

    public Vector3 direcion { get => _direcion; set => _direcion = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnInput();

        if (GameManager.Instance.loseEnemy >= 3)
        {
            Destroy(gameObject);
            GameManager.Instance.isGameActive = false;
        }
    }

    private void FixedUpdate()
    {
        OnMove();
    }

    void OnInput()
    {
        _direcion = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f);
    }

    void OnMove()
    {
        transform.position += _direcion * Time.fixedDeltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            GameManager.Instance.isGameActive = false;
        }
    }
}
