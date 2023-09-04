using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Stardew.InventorySystem
{
    public class UIShop : MonoBehaviour
    {
    [Header("Category")]
    [SerializeField] Text categoryText;

    [Header("Item List")]
    [SerializeField] UIItem itemUIPrefab;
    [SerializeField] List<UIItem> itemUIList = new List<UIItem>();
    [SerializeField] int itemPrice;
    [SerializeField] Text itemPriceText;

        public void SetCategory(CategoryInfo info)
        {
            categoryText.text = info.name;
        }
        
        public void SetItemList(UIItem_Data[] uiDatas)
        {

        }
    
    }
    
    [Serializable]
    public class CategoryInfo
    {
        public string name;
    }
}