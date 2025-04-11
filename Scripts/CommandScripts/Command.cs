using System;
using UnityEngine.WSA;


namespace Core
{
    /// <summary>
    /// ������� ��������, ������� ���������
    /// ������� ���������: "������������", 
    /// "��������������" � "� �����".
    /// </summary>
    public class Command
    {
        // ��������� �������
        protected enum CommandState
        {
            AT_REST,
            ACTIVATED,
            DEACTIVATED
        }

        // ������� ��������� �������
        private CommandState _curState;


        /// <summary>
        /// �����������, �������� "� �����" ���
        /// ��������� �������� �������� ���������.
        /// </summary>
        public Command() => _curState = CommandState.AT_REST;


        /// <summary>
        /// ���������� �������.
        /// </summary>
        public void Activate() => SetState(CommandState.ACTIVATED);


        /// <summary>
        /// ������������ �������.
        /// </summary>
        public void Deactivate() => SetState(CommandState.DEACTIVATED);


        /// <summary>
        /// ��������� ������� � ��������� �����.
        /// </summary>
        public void Reset() => SetState(CommandState.AT_REST);


        /// <summary>
        /// ���������� true, ���� ������� ������������;
        /// � ��������� ������ - false.
        /// </summary>
        public bool IsActivated() => _curState == CommandState.ACTIVATED;


        /// <summary>
        /// ���������� true, ���� ������� ��������������;
        /// � ��������� ������ - false.
        /// </summary>
        public bool IsDeactivated() => _curState == CommandState.DEACTIVATED;


        /// <summary>
        /// ���������� true, ���� ������� ��������� � ��������� �����;
        /// � ��������� ������ - false.
        /// </summary>
        public bool IsAtRest() => _curState == CommandState.AT_REST;


        /// <summary>
        /// ��������� ������� � �������� ���������.
        /// </summary>
        /// <param name="newState">����� ���������</param>
        protected virtual void SetState(CommandState newState)
        {
            _curState = newState;
        }
    }
}
