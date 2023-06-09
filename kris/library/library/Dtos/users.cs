using WebApplication1.Entities;
using WebApplication1.Mapper;

namespace WebApplication1.Dtos;

public class users : IMapFrom<Person>
{
    public long Id { get; set; }

    public string Name { get; set; }
    public string Age { get; set; }
}