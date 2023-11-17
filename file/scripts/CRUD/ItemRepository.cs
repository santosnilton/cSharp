using System;
using System.Collections.Generic;
using System.Linq;

public class ItemRepository
{
    private List<Item> items;

    public ItemRepository()
    {
        // Inicializar a lista (simulando um banco de dados)
        items = new List<Item>();
    }

    public void Create(Item item)
    {
        // Gera um novo ID (pode ser substituído por um mecanismo de geração de ID mais sofisticado)
        item.Id = items.Count + 1;
        items.Add(item);
    }

    public Item Read(int id)
    {
        return items.FirstOrDefault(i => i.Id == id);
    }

    public void Update(Item updatedItem)
    {
        var existingItem = items.FirstOrDefault(i => i.Id == updatedItem.Id);

        if (existingItem != null)
        {
            existingItem.Type = updatedItem.Type;
            existingItem.Description = updatedItem.Description;
            existingItem.Name = updatedItem.Name;
            existingItem.Value = updatedItem.Value;
        }
        else
        {
            Console.WriteLine("Item not found");
        }
    }

    public void Delete(int id)
    {
        var itemToDelete = items.FirstOrDefault(i => i.Id == id);

        if (itemToDelete != null)
        {
            items.Remove(itemToDelete);
        }
        else
        {
            Console.WriteLine("Item not found");
        }
    }

    public List<Item> GetAll()
    {
        return items;
    }
}
