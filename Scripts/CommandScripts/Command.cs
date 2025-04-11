using System;
using UnityEngine.WSA;


namespace Core
{
    /// <summary>
    /// Простая сущность, имеющая несколько
    /// простых состояний: "активирована", 
    /// "деактивирована" и "в покое".
    /// </summary>
    public class Command
    {
        // Состояния команды
        protected enum CommandState
        {
            AT_REST,
            ACTIVATED,
            DEACTIVATED
        }

        // Текущее состояние команды
        private CommandState _curState;


        /// <summary>
        /// Конструктор, задающий "в покое" как
        /// начальное значение текущего состояния.
        /// </summary>
        public Command() => _curState = CommandState.AT_REST;


        /// <summary>
        /// Активирует команду.
        /// </summary>
        public void Activate() => SetState(CommandState.ACTIVATED);


        /// <summary>
        /// Деактивирует команду.
        /// </summary>
        public void Deactivate() => SetState(CommandState.DEACTIVATED);


        /// <summary>
        /// Переводит команду в состояние покая.
        /// </summary>
        public void Reset() => SetState(CommandState.AT_REST);


        /// <summary>
        /// Возвращает true, если команда активирована;
        /// в противном случае - false.
        /// </summary>
        public bool IsActivated() => _curState == CommandState.ACTIVATED;


        /// <summary>
        /// Возвращает true, есил команда деактивирована;
        /// в противном случае - false.
        /// </summary>
        public bool IsDeactivated() => _curState == CommandState.DEACTIVATED;


        /// <summary>
        /// Возвращает true, если команда находится в состоянии покоя;
        /// в противном случае - false.
        /// </summary>
        public bool IsAtRest() => _curState == CommandState.AT_REST;


        /// <summary>
        /// Переводит команду в заданное состояние.
        /// </summary>
        /// <param name="newState">Новое состояние</param>
        protected virtual void SetState(CommandState newState)
        {
            _curState = newState;
        }
    }
}
