
using ex3.Models;
using Microsoft.EntityFrameworkCore;

namespace ex3.Repository
{
    public class TaskRepository : ITaskRepository
    {

        private readonly TasksDBcontext _dbContext;

        public TaskRepository(TasksDBcontext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Tasks> GetTasks()
        {
            return _dbContext.Tasks;
        }

        public Tasks? CreateNewTask(Tasks Task)//האם ככה עושים אפשרות של החזרת נאל?
        {
            User? isExistUser = _dbContext.Users.ToList().FirstOrDefault(u => u.Id == Task.UserId);
            Project? isExistProject = _dbContext.Projects.ToList().FirstOrDefault(p => p.ProjectId == Task.ProjectId);

            if (isExistUser != null && isExistProject != null)
            {
                _dbContext.Tasks.Add(Task);
                _dbContext.SaveChanges();
                return Task;
            }
            else
                return null;
        }

        public void UpdateTask(Tasks task)
        {
            if (task == null) throw new ArgumentNullException(nameof(task));
            _dbContext.Tasks.Update(task);
            _dbContext.SaveChanges();
        }

        public void DeleteTask(int id)
        {
            var task = _dbContext.Tasks.Find(id);
            if (task != null)
            {
                _dbContext.Tasks.Remove(task);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Tasks> getTasksUser(int userId)
        {
            return _dbContext.Tasks.Where(y => y.UserId == userId).ToList();
        }
    }
}
