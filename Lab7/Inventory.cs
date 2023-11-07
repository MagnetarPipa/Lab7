﻿using System.Text;

namespace Lab7
{
    /// <summary>
    /// Класс для управления предметами в инвентаре
    /// </summary>
    internal class Inventory
    {
        HashSet<Item> inventoryList = new HashSet<Item>();

        /// <summary>
        ///  Добавление нового уникального предмета в HashSet
        /// </summary>
        /// <param name="newItem">Новый предмет для добавления в инвентарь,идет проверка на уникальность предмета.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void AddItem(Item newItem)
        {
            if (newItem is not null)
            {
                foreach (Item part in inventoryList)
                {
                    //Проверка на уникальность предметов в инвентаре,если ID предмета совпадает с другим значит такой предмет уже есть в инвентаре.
                    if (part.Id.Equals(newItem.Id))
                    {
                        throw new ArgumentOutOfRangeException("В инвентаре уже есть этот предмет");
                    }
                }
                inventoryList.Add(newItem);
            }
            else
            {
                Console.WriteLine(newItem);
                throw new ArgumentOutOfRangeException("В инвентаре уже есть этот предмет");
            }
        }

        /// <summary>
        /// Удаление предмета из инвентаря
        /// </summary>
        /// <param name="itemToDelete"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void DeleteItem(Item itemToDelete)
        {
            if (itemToDelete is not null && inventoryList.Contains(itemToDelete))
            {
                inventoryList.Remove(itemToDelete);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Таково предмета не существует");
            }
        }


        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (Item part in inventoryList)
            {
                str.Append(part + "\n");
            }
            return str.ToString();
        }
    }
}
