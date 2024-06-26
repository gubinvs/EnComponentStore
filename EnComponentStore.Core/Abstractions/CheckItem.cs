using EnComponentStore.Core.Models;

namespace EnComponentStore.Core.Abstractions
{
    /// <summary>
    /// ����������� ����� � ���������� ������������� ��� �������� �� ������ ���������� ���� � �������� ����� ����������� ������
    /// </summary>
    internal class CheckItem
    {
        /// <summary>
        /// ����� ������������ �������
        /// </summary>
        /// 
        public string str = string.Empty;

        /// <summary>
        /// ��������� � ���������� ����� �������� � ����
        /// </summary>
        public const int MAXIMUM_TEXT_LENGTH = 255;
    }
}