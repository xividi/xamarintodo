using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms; 

namespace todo
{
	public class TodoListViewModel
	{
		public ObservableCollection<TodoItem> TodoItems { get; set; }

		public TodoListViewModel()
		{
			TodoItems = new ObservableCollection<TodoItem>();

			TodoItems.Add(new TodoItem("item 1", true));
			TodoItems.Add(new TodoItem("item 2", false));
			TodoItems.Add(new TodoItem("item 3", false));

		}

		//command will execute when 
		public ICommand AddTodoCommand => new Command(AddTodoItem); 
		public string TodoInputValue { get; set; }
		//listening for a change to push to the command
		void AddTodoItem()
		{
			TodoItems.Add(new TodoItem(TodoInputValue, false));
		}

		public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
		void RemoveTodoItem(object o)
		{
			TodoItem todoItemBeingRemoved = o as TodoItem;
			TodoItems.Remove(todoItemBeingRemoved);
		}

    }
}

