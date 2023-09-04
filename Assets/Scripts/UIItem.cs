using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Stardew.InventorySystem
{
public class UIItem : MonoBehaviour
{
    [SerializeField] Image itemIconImage;
    [SerializeField] Text itemNameText;
    [SerializeField] Text categoryNameText;
    [SerializeField] Text descriptionText;

    /*or if we are a bit lazy
    [SerializedField] Image itemDescription;
    */

    [SerializeField] Image selectedImage;

  public void SetData(UIItem_Data data)
    {
        itemNameText.text = data.itemData.displayName;
        //categoryNameText.text = data.itemData.displayCategoryName;
        descriptionText.text = data.itemData.description;
        //itemDescription.image = data.itemData.displayItemDesctiption;
        
        selectedImage.gameObject.SetActive(data.isSelected);
    }
    } 

    public class UIItem_Data
    {
    public ItemData itemData;
    public bool isSelected;

    public UIItem_Data(ItemData itemData, bool isSelected)
    {
        this.itemData = itemData;
        this.isSelected = isSelected;
    }
    
    }

}