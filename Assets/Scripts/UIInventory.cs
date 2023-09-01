using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Stardew.InventorySystem
{
public class UIInventory : MonoBehaviour
{
    [Header("Item")]
    [SerializeField] Text itemCount;
    
    [Header("Currencies")]
    [SerializeField] int golds;
    [SerializeField] Text showCurrentGolds;

    void Start()
    {
        
    }

    public void SetItemInfo()
    {

    }

    public void SetCurrenciesInfo()
    {
        
    }
}
}