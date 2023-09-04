using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Stardew.InventorySystem
{
    public class UIShop : MonoBehaviour
    {
    [Header("Item List")]
    [SerializeField] UIItem itemUIPrefab;
    [SerializeField] List<UIItem> itemUIList = new List<UIItem>();
    [SerializeField] int itemPrice;
    [SerializeField] TMP_Text itemPriceText;
    [SerializeField] GameObject description;
        
        void Start()
        {

        }

        public void SetItemList(UIItem_Data[] uiDatas)
        {
            ClearAllItemUIs();
            foreach(var uiItemData in uiDatas)
            {
            var newItemUI = Instantiate(itemUIPrefab,itemUIPrefab.transform.parent,false);

            newItemUI.gameObject.SetActive(true);
            itemUIList.Add(newItemUI);
            newItemUI.SetData(uiItemData);
            }
        }

        public void ClearAllItemUIs()
        {
            foreach (UIItem uiItem in itemUIList)
                Destroy(uiItem.gameObject);
            
            itemUIList.Clear();
        }

        public void ShowItemDescription(Vector3 position)
        {
            description.SetActive(true);
            description.transform.position = position;
        }

        public void HideItemDescription()
        {
            description.SetActive(false);
        }
    
    }
    
    [Serializable]
    public class CategoryInfo
    {
        public string name;
    }
}