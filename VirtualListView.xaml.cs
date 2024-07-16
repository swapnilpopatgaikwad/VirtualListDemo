using VirtualListDemo.ViewModel;

namespace VirtualListDemo;

public partial class VirtualListView : ContentPage
{
	public VirtualListView()
	{
		InitializeComponent();
        BindingContext = new VirtualizeListViewModel();
    }

    private void Button_Clicked_Add(object sender, EventArgs e)
    {
    }

    private void Button_Clicked_Remove(object sender, EventArgs e)
    {
    }

    private void Button_Clicked_Replace(object sender, EventArgs e)
    {
    }

    private void Button_Clicked_Move(object sender, EventArgs e)
    {
    }
}