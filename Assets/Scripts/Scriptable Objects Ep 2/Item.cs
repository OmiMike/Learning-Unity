using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Inventory/Items/Health")]
public class Item : ScriptableObject {
    public enum HealthPacks {
        low,
        mid,
        high
    }

    #region VARIABLES
    public string itemName;
    public float itemAmountHP;

    [Space]
    public HealthPacks hp;
    #endregion
}
