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
    
    [Header("Category")]
    [SerializeField] Image categoryIconImage;
    [SerializeField] Text categoryText;

    [Header("Current Item")]
    [SerializeField] Image currentItemIconImage; 
    [SerializeField] Text descriptionText;


        
        void Start()
        {
            itemUIPrefab.gameObject.SetActive(false);
        }

        public void SetCategory(CategoryInfo info)
        {
            //categoryIconImage.sprite = info.icon;
            //categoryText.text = info.name;
        }

        public void SetCurrentItemInfo(ItemData data)
        {
            //descriptionText.text = data.description;
            //currentItemIconImage.sprite = data.icon;
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
        public Sprite icon;
        public string name;
    }
}