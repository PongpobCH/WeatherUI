using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

namespace Stardew.InventorySystem
{
public class UIItem : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    [SerializeField] Image itemImage;
    [SerializeField] TMP_Text itemName;
    [SerializeField] TMP_Text countText;
    [SerializeField] UIShop uiShop;

    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text typeText;
    [SerializeField] TMP_Text description;

    public UIItem_Data itemDescription;
    public void SetData(UIItem_Data data)
    {
        itemImage.sprite = data.itemData.icon;
        itemName.text = data.itemData.displayName;
        countText.text = data.itemData.count.ToString();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        nameText.text = itemDescription.itemData.displayName;
        typeText.text = itemDescription.itemData.type.ToString();
        description.text = itemDescription.itemData.description;
        
        uiShop.ShowItemDescription(transform.position);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        uiShop.HideItemDescription();
    }

    } 

    public class UIItem_Data
    {
    public ItemData itemData;

    public UIItem_Data(ItemData itemData)
    {
        this.itemData = itemData;
    }
    
    }

}