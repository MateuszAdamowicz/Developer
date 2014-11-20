using Developer.Models.ApplicationModels;
using Developer.Models.ViewModels;

namespace Developer.Services.Admin
{
    public interface IWorkerService
    {
        Result AddWorker(AdminWorker adminWorker);
        Result EditWorker(AdminWorker adminWorker, int id);
    }
}