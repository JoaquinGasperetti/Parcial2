using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    public int gold = 0;
    public TMP_Text goldText;

    void Start()
    {
        UpdateGoldUI();
    }

    public void AddGold(int amount)
    {
        gold += amount;
        UpdateGoldUI();
    }

    void UpdateGoldUI()
    {
        if (goldText != null)
            goldText.text = "Oro: " + gold;
    }
}
