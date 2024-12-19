using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacles : MonoBehaviour
{

    public GameObject LifeCanva;
    [SerializeField]
    private Vector2 startPosition;
    [SerializeField]
    private Vector2 endPosition;
    private float x = 0f;
    private float speed = .5f; 


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            LifeCanva.SetActive(true);
            Time.timeScale = 0;
        }

    }

    private void Update()
    {
        x += Time.deltaTime * speed;
        transform.position = Vector2.Lerp(startPosition, endPosition, x);
    }
}
