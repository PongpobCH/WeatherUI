using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Stardew.InventorySystem
{
    public class GoldManager : MonoBehaviour
    {
        [SerializeField] TMP_Text goldText;
        public int goldCount = 0;

        void Update()
        {
            goldText.text = goldCount.ToString(); 
        }
    }
}
