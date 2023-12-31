﻿using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Common.Utilities.UI.UIButton
{
    [RequireComponent(typeof(Button))]
    public abstract class ButtonBase : MonoBehaviour
    {
        private protected Button SelectableButton;

        private protected void Awake() => SelectableButton = GetComponent<Button>();

        private protected virtual void OnEnable() => SelectableButton.onClick.AddListener(OnClick);

        private protected virtual void OnDisable() => SelectableButton.onClick.RemoveListener(OnClick);

        private protected abstract void OnClick();
    }
}