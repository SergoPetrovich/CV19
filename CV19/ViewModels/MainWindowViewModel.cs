﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel: ViewModel
    {
        #region Заголовок окна
        private string _Title = "Анализ статистики CV19";
        /// <summary>Заголовок окна</summary>

        public string Title
        {
            get => _Title;
            //set
            //{
            //    if (Equals(_Title, value)) return;
            //    _Title = value;
            //    OnPropertyChanged();
            //}
            set => Set(ref _Title, value);
        }
        #endregion
    }
}
