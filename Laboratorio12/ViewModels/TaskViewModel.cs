﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Laboratorio12.ViewModels
{
    public class TaskViewModel : BaseViewModel
    {
        private ObservableCollection<Models.Task> _tasks;
        private string _title;
        private string _description;
        private string _status;

        private ObservableCollection<Models.Task> _storedTasks;

        public ObservableCollection<Models.Task> Tasks
        {
            get => _tasks;
            set
            {
                _tasks = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged();
            }
        }

        public ICommand Save => new Command(ExecuteSave);
        public ICommand Get => new Command(ExecuteGet);

        public TaskViewModel()
        {
            _storedTasks = new ObservableCollection<Models.Task>();
            _tasks = new ObservableCollection<Models.Task>();
        }

        private void ExecuteSave()
        {
            var newTask = new Models.Task
            {
                Title = Title,
                Description = Description,
                Status = Status
            };

            
            _storedTasks.Add(newTask);

 
            Title = string.Empty;
            Description = string.Empty;
            Status = string.Empty;
        }

        private void ExecuteGet()
        {
            
            Tasks.Clear();

      
            foreach (var task in _storedTasks)
            {
                Tasks.Add(task);
            }
        }
    }
}
