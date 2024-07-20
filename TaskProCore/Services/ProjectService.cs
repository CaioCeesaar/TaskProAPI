using System.Collections.Generic;
using System.Threading.Tasks;
using TaskProCore.Entities;
using TaskProCore.Interfaces;
using Task = System.Threading.Tasks.Task;

namespace TaskProCore.Services;

public class ProjectService : IProjectService
{
    public Task<IEnumerable<Project>> GetAllProjectsAsync()
    {
        throw new System.NotImplementedException();
    }

    public Task<Project> GetProjectByIdAsync(int id)
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