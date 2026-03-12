using TMPro;
using UnityEngine;

public class HitsManager : MonoBehaviour
{
    public TextMeshProUGUI hitText;
    public static int hits = 0;

    void Update()
    {
        hitText.text = "Hits: " + hits;
    }
}
