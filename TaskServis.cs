using BlazorCalendar.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class TaskService
{
    public Task<List<TaskItem>> GetTasksAsync()
    {
        var tasks = new List<TaskItem>
        {
            new TaskItem { DueDate = DateTime.Today, Description = "Поприбирати кімнату" },
            new TaskItem { DueDate = DateTime.Today, Description = "Приготувати вечерю" },
            new TaskItem { DueDate = DateTime.Today, Description = "Зробити зарядку" },
            // Додайте інші завдання за бажанням
        };

        return Task.FromResult(tasks);
    }
}
