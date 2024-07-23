using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskProCore.Models;
using Task = System.Threading.Tasks.Task;

namespace TaskProCore.Interfaces;

public interface ITaskService : IDisposable
{
    Task<Project> CreateProjectAsync(Project project);
    Task UpdateProjectAsync(Project project);
    Task DeleteProjectAsync(int id);
}