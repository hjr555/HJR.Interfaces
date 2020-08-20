using System.Threading.Tasks;

namespace HJR.Interfaces
{
    public interface IoEmbedService<T>
    {
        public Task<T> GetAsync(int id);
    }
}
