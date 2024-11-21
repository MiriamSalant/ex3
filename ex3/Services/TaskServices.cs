﻿using ex3.Models;
using ex3.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ex3.Services
{
    public class TaskServices : ITaskServices
    {
        private readonly ITaskRepository _taskRepository;

        public TaskServices(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public IEnumerable<Tasks> GetTasks()
        {
            return _taskRepository.GetTasks();
        }

        public Tasks? CreateNewTask(Tasks newTask)
        {
            return _taskRepository.CreateNewTask(newTask);
        }
     
        public void UpdateTask(Tasks task)
        {
            _taskRepository.UpdateTask(task);
        }

        public void DeleteTask(int id)
        {
            _taskRepository.DeleteTask(id);
        }

        public void getTasksUser(int userId)
        {
            _taskRepository.getTasksUser(userId);
        }
    }
}
