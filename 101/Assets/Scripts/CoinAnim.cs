using UnityEngine;

public class CoinAnim : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 360f, 0) * Time.deltaTime);
    }
}
