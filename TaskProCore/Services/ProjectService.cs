﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TaskProCore.Entities;
using TaskProCore.Interfaces;
using TaskProCore.Models;
using Task = System.Threading.Tasks.Task;

namespace TaskProCore.Services;

public class ProjectService(IProjectRepository projectRepository, INotifier notifier)
    : BaseService(notifier), IProjectService
{
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

    public void Dispose()
    {
        throw new System.NotImplementedException();
    }
}