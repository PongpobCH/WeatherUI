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
    public GameObject itemImage;
    [SerializeField] TMP_Text itemName;
    [SerializeField] TMP_Text countText;
    [SerializeField] UIShop uiShop;
    [SerializeField] ItemData ItemData;

    [Header("Description")]
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text typeText;
    [SerializeField] TMP_Text description;
    [SerializeField] TMP_Text price;
    [SerializeField] GoldManager goldManager;

    public void SetData(UIItem_Data data)
    {
        Image imageComponent = itemImage.GetComponent<Image>();
        imageComponent.sprite = data.itemData.icon;
        itemName.text = data.itemData.displayName;
        countText.text = data.itemData.count.ToString();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        /*if (eventData.pointerEnter.transform.name == itemDescription.itemData.displayName)
        {
        nameText.text = itemDescription.itemData.displayName;
        typeText.text = itemDescription.itemData.type.ToString();
        description.text = itemDescription.itemData.description;
        price.text = itemDescription.itemData.count.ToString();
        }*/
        
        uiShop.ShowItemDescription(transform.position);
        Debug.Log("Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        uiShop.HideItemDescription();
        Debug.Log("Exit");
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