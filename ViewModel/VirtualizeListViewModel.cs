using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using VirtualListDemo.Model;

namespace VirtualListDemo.ViewModel
{
    public partial class VirtualizeListViewModel :ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<DataModel> _dataModels;
        public VirtualizeListViewModel() 
        {
            DataModels = new ObservableCollection<DataModel>(GetDataModels());
        }

        public List<DataModel> GetDataModels()
        {
            var list = new List<DataModel>();
            for(int i = 0  ; i < 400; i++)
            {
                list.Add(new DataModel()
                {
                    Id = i,
                    Title = $"Item value {i}",
                    Description = $" Description : Item value {i}"
                });
            }
            return list;
        }
    }
}
