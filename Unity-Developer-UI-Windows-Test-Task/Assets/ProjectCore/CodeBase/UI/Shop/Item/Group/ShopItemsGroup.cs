﻿using TMPro;
using UnityEngine;

namespace CodeBase.UI.Shop.Item.Group
{
    public class ShopItemsGroup : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _name;
        [SerializeField] private Transform _itemsRoot;

        public void Initialize(ShopItemGroupType groupType) => _name.text = groupType.ToString();

        public Transform GetItemsRoot() => _itemsRoot;
    }
}