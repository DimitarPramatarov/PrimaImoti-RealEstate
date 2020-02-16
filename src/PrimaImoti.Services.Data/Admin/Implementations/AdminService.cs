using PrimaImoti.Data;
using System.Threading.Tasks;

namespace PrimaImoti.Services.Data.Admin.Implementations
{
    public class AdminService 
    {
        private readonly ApplicationDbContext context;

        public AdminService(ApplicationDbContext context)
        {
            this.context = context;
        }

       
    }
}
