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
    [SerializeField] GameObject description;
        
        void Start()
        {
            itemUIPrefab.gameObject.SetActive(false);
        }
        public void ClearAllItemUIs()
        {
            foreach (UIItem uiItem in itemUIList)
                Destroy(uiItem.gameObject);
            
            itemUIList.Clear();
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

        public void ShowItemDescription()
        {
            description.SetActive(true);
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