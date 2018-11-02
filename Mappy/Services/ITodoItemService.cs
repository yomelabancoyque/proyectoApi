using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mappy.Models;

namespace Mappy.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}M