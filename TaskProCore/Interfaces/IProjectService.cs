using System.Collections.Generic;
using System.Threading.Tasks;
using TaskProCore.Entities;
using TaskProCore.Models;
using Task = System.Threading.Tasks.Task;

namespace TaskProCore.Interfaces;

public interface IProjectService
{
    Task<IEnumerable<Project>> GetAllProjectsAsync();
    Task<Project> GetProjectByIdAsync(int id);
    Task<Project> CreateProjectAsync(Project project);
    Task UpdateProjectAsync(Project project);
    Task DeleteProjectAsync(int id);
}