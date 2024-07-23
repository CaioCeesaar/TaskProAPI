using System.Threading.Tasks;
using TaskProCore.Entities.Enums;

namespace TaskProCore.Interfaces;

public interface ITaskRepository :  IRepository<Models.Task>
{
    Task<Models.Task> GetTaskCommentsAsync(int taskId);
    Task<Models.Task> GetTaskByStatusAsync(int taskId, Status status);
    Task<Models.Task> GetTaskByPriorityAsync(int taskId, Priority priority);
    Task RemoveUserFromTaskAsync(int taskId, int userId);
    Task RemoveCommentFromTaskAsync(int taskId, int commentId);
    Task RemoveTaskFromProjectAsync(int taskId, int projectId);
}