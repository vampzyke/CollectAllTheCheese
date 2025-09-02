using UnityEngine;

public class Coins : MonoBehaviour
{

    [SerializeField] GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.CoinCollected();
        Destroy(gameObject);
    }
}
