using rESTauranter.Models;
using System.Collections.Generic;
namespace rESTauranter.Factory
{
    public interface IFactory<T> where T : BaseEntity
    {
    }
}