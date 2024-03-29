using UnityEngine;

public class ShopTrigger : MonoBehaviour
{
    public Canvas shopCanvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shopCanvas.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shopCanvas.enabled = false;
        }
    }
   
}
