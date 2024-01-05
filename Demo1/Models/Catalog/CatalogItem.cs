namespace Demo1.Models.Catalog;

public class CatalogItem
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public CatalogItem(string id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}