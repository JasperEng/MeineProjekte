using UnityEngine;

public class CoinController : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, 90 * Time.deltaTime, 0));
    }
}
