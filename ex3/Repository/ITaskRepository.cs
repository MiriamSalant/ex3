using ex3.Models;

namespace ex3.Repository
{
    public interface ITaskRepository
    {
        IEnumerable<Tasks> GetTasks();
        Tasks? CreateNewTask(Tasks Task);

        void UpdateTask(Tasks task);

        void DeleteTask(int id);
        IEnumerable<Tasks> getTasksUser(int id);
    }
}
