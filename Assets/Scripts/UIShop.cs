using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Stardew.InventorySystem
{
public class UIShop : MonoBehaviour
{
    [Header("Item List")]
    [SerializedField] UIItem itemUIPrefab;
    [SerializedField] List<UIItem> itemUIList = new List<UIItem>();
    [SerializedField] int itemPrice;
    [SerializedField] Text itemPriceText;

    /*public void SetItemList(UIItem_Data[] uiDatas)
    {

    }*/
}
}