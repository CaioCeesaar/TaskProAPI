using System.Collections.Generic;
using System.Threading.Tasks;
using TaskProCore.Interfaces;
using TaskProCore.Models;
using Task = System.Threading.Tasks.Task;

namespace TaskProCore.Services;

public class TaskService(ITaskRepository projectRepository, INotifier notifier)
    : BaseService(notifier), ITaskService
{
    public void Dispose()
    {
        throw new System.NotImplementedException();
    }

    public Task<Project> CreateProjectAsync(Project project)
    {
        throw new System.NotImplementedException();
    }

    public Task UpdateProjectAsync(Project project)
    {
        throw new System.NotImplementedException();
    }

    public Task DeleteProjectAsync(int id)
    {
        throw new System.NotImplementedException();
    }
}