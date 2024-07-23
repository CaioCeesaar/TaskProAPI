using System.Threading.Tasks;
using TaskProCore.Entities;
using TaskProCore.Entities.Enums;
using TaskProCore.Models;
using Task = System.Threading.Tasks.Task;

namespace TaskProCore.Interfaces;

public interface IProjectRepository : IRepository<Project>
{
    Task<Project> GetProjectTasksAsync(int projectId);
    Task<Project> GetProjectByStatusAsync(int projectId, Status status);
    Task<Project> GetProjectByPriorityAsync(int taskId, Priority priority);
    Task<Comment> GetProjectCommentsAsync(int projectId);
    Task RemoveUserFromProjectAsync(int projectId, int userId);
    Task RemoveTaskFromProjectAsync(int projectId, int taskId);
    Task RemoveCommentFromProjectAsync(int projectId, int commentId);
}