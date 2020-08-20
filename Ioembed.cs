using System.Threading.Tasks;

namespace HJR.Interfaces
{
    public interface IOEmbed<T>
    {
        public Task<T> GetAsync(int id);
    }
}
