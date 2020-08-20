using System.Threading.Tasks;

namespace HJR.Interfaces
{
    public interface ISerializer<T>
    {
        Task<string> SerializeAsync(T obj);
        Task<T> DeserializeAsync(string json);
    }
}
