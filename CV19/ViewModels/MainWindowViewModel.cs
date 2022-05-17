﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel:ViewModel
    {
        private string _Title="Анализ статистики CV19";
        public string Title
        {
            //get { return _Title; }
            //set { _Title = value; }
            get => _Title;
            set=>Set(ref _Title, value);
        }
    }
}
