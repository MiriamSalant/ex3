﻿
using ex3.Models;
using Microsoft.AspNetCore.Mvc;

namespace ex3.Services
{
    public interface ITaskServices
    {
        IEnumerable<Tasks> GetTasks();
        Tasks? CreateNewTask(Tasks task);

        void DeleteTask(int id);

        void UpdateTask(Tasks task);

        void getTasksUser(int userId);
    }
}
