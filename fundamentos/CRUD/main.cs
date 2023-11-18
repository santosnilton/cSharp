class Program
{
    static void Main()
    {
        ItemRepository repository = new ItemRepository();

        // Criar um item
        Item newItem = new Item
        {
            Type = "Type1",
            Description = "Description1",
            Name = "Name1",
            Value = 10.50m
        };
        repository.Create(newItem);

        // Ler um item
        Item readItem = repository.Read(newItem.Id);
        Console.WriteLine($"Read Item: {readItem.Name}");

        // Atualizar um item
        readItem.Name = "UpdatedName";
        repository.Update(readItem);

        // Deletar um item
        repository.Delete(readItem.Id);

        // Obter todos os itens restantes
        List<Item> allItems = repository.GetAll();
        Console.WriteLine("All Items:");
        foreach (var item in allItems)
        {
            Console.WriteLine($"{item.Id} - {item.Name}");
        }
    }
}
