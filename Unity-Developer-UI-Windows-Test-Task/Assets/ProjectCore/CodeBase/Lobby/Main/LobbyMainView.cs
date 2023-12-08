﻿using System.Collections.Generic;
using CodeBase.Lobby.WindowsManager;
using UnityEngine;

namespace CodeBase.Lobby.Main
{
    public class LobbyMainView : MonoBehaviour
    {
        [SerializeField] private List<LobbyMainToggleWindowButton> _toggleButtons;

        public void Initialize(LobbyMainAdapter lobbyMainAdapter, LobbyAudioManager audioManager)
        {
            foreach (var button in _toggleButtons)
                button.Initialize(lobbyMainAdapter, audioManager);
        }

        public Transform GetViewsRoot() => gameObject.transform;
    }
}