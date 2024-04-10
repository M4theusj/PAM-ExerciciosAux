using System.Collections.ObjectModel;

namespace Exercicios;

public partial class Contatos : ContentPage
{
    private ObservableCollection<string> items = new ObservableCollection<string>();

    public Contatos()
    {
        InitializeComponent();
        myListView.ItemsSource = items;
    }

    private void AddContatos_Clicked(object sender, EventArgs e)
    {
        string name = Convert.ToString(ContactName.Text);
        string number = Convert.ToString(ContactNumber.Text);
        items.Add($"Nome: {name} Número: {number}");
    }
}