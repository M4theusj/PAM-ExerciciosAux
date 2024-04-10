namespace Exercicios;

public partial class Texto : ContentPage
{
	public Texto()
	{
		InitializeComponent();
	}

    private void TextChange_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        TextWorld.FontSize = (int)e.NewValue;
        TextWorld.TextColor = Color.FromRgba(255, 0, 0, 255);
    }
}