﻿using System.Collections.Generic;
using CodeBase.Lobby.Data;
using CodeBase.Utilities.UI;
using UnityEngine;

namespace CodeBase.Project.Services.WindowsManagerService
{
    public class WindowsManager
    {
        private readonly Dictionary<WindowType, IWindow> _registeredWindows = new();
        private Transform _windowsRoot;
        private IWindow _currentWindow;

        public void Initialize(Transform windowsRoot) => _windowsRoot = windowsRoot;

        public Transform WindowsRoot => _windowsRoot;
        
        public void RegisterWindow(WindowType type, IWindow window) => _registeredWindows.Add(type, window);

        public void ToggleCurrentWindow(WindowType type)
        {
            var window = _registeredWindows[type];

            CloseCurrentWindow();

            if (_currentWindow != window)
                OpenWindow(window);
        }

        public void CloseCurrentWindow()
        {
            _currentWindow?.Close();
            _currentWindow = null;
        }

        private void OpenWindow(IWindow window)
        {
            _currentWindow = window;
            _currentWindow.Open();
        }
    }
}