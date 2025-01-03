using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject LifeCanva;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            LifeCanva.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
