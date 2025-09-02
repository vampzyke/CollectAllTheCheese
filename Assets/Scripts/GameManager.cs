using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int coinsCollected;
    [SerializeField] TextMeshProUGUI coinsCollectedText;

    public void CoinCollected()
    {
        coinsCollected++;
        coinsCollectedText.text = "Coins Collected: " + coinsCollected;
    }

}
