using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using ToDoApp.Models;

namespace ToDoApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            MenuModels = new ObservableCollection<MenuModel>();
            menuModels.Add(new MenuModel() { IconFont = "\xe635", Title = "我的一天", BackColor = "#218868", Count = 5, Display = false });
            menuModels.Add(new MenuModel() { IconFont = "\xe6b6", Title = "重要", BackColor = "#EE3B3B", Count = 5 });
            menuModels.Add(new MenuModel() { IconFont = "\xe6e1", Title = "已计划日程", BackColor = "#218868", Count = 5 });
            menuModels.Add(new MenuModel() { IconFont = "\xe614", Title = "已分配给我", BackColor = "#EE3B3B", Count = 5 });
            menuModels.Add(new MenuModel() { IconFont = "\xe755", Title = "任务", BackColor = "#218868", Count = 5 });


            SelectedCommand = new RelayCommand<MenuModel>(t => Select(t));
        }

        private ObservableCollection<MenuModel> menuModels;

        public ObservableCollection<MenuModel> MenuModels
        {
            get { return menuModels; }
            set { menuModels = value; RaisePropertyChanged(); }
        }

        public RelayCommand<MenuModel> SelectedCommand { get; set; }

        private MenuModel menuModel;

        public MenuModel MenuModel
        {
            get { return menuModel; }
            set { menuModel = value; RaisePropertyChanged(); }
        }


        private void Select(MenuModel model)
        {
            MenuModel = model;
        }
    }
}