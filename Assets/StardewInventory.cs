using System;
using System.Collections.Generic;
using UnityEngine;

namespace Stardew.InventorySystem
{
    public class StardewInventory : MonoBehaviour
    {
        public ItemData[] Items => itemList.ToArray();
        [SerializeField] List<ItemData> itemList = new List<ItemData>();

        public ItemData[] GetItemsByName(ItemName targetName)
        {
            //Create a list that will hold all the items that matched the targetType
            var resultList = new List<ItemData>();
            foreach (var itemData in itemList)
            {
                if (itemData.type == targetName)
                    resultList.Add(itemData);
            }

            //Return the result as Array not List. Because we don't want caller to modify the result afterward.
            return resultList.ToArray();
        }

        public void Add(ItemData itemToAdd)
        {
            
        }

        public void Remove(ItemData itemToRemove)
        {
            
        }
    }

    [Serializable]
    public class ItemData
    {
        public string displayName;
        public string description;
        public Sprite icon;
        public ItemName type;
        public int count;
    }

    public enum ItemName
    {
        Seeds, 
        Sapling, 
        Herbs, 
        Others
    }
}
