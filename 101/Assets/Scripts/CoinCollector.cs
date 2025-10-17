using UnityEngine;
using TMPro;
public class CoinCollector : MonoBehaviour
{
  private int coinsCollected;
  [SerializeField] private TextMeshProUGUI scoreText;
  void OnTriggerEnter(Collider other)
    {
    if (other.gameObject.tag == "Coin")
    {
      coinsCollected++;
      Destroy(other.gameObject);
      scoreText.text = coinsCollected.ToString();
    }
    }
}
