using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    #region VARIABLES
    [SerializeField] Item item;
    [SerializeField] float hpAmount;
    [SerializeField] string hpName;
    #endregion

    #region UNITY METHODS
    void Start() {
        ShowHealth();
    }

    void Update() {
        
    }
    #endregion

    #region PUBLIC METHODS
    public void ShowHealth() {
        hpAmount = item.itemAmountHP;
        hpName = item.itemName;
    }
    #endregion
}
