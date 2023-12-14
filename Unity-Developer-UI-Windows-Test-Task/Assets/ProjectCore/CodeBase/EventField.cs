﻿using System;

namespace CodeBase.Lobby.Infrastructure.States
{
    public class EventField<T>
    {
        private T _value;

        public EventField(T value) => _value = value;

        public event Action<T> OnChanged;

        public T Value
        {
            get => _value;
            set
            {
                _value = value;
                OnChanged?.Invoke(_value);
            }
        }
    }
}