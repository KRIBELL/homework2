using WebApplication1.Entities;
using WebApplication1.Mapper;

namespace WebApplication1.Dtos;

public class Libraru : IMapFrom<Animal>
{

    public long Id { get; set; }

    public string Name { get; set; }
    public string janr{ get; set; }
    public string avtor { get; set; }

    public users Person { get; set; }
}