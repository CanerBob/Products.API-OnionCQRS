using API.Domain.Comman;

namespace API.Domain.Entities;
public class Category:EntityBase
{
    public Category(){}
    public Category(int parentId,string name,int priory)
    {
        Name = name;
        ParentId = parentId;
        Priorty = priory;
    }
    public int ParentId { get; set; }
    public string Name { get; set; }
    public int Priorty { get; set; }
    public ICollection<Detail> Details { get; set; }
    public ICollection<Product> Products { get; set; }
}