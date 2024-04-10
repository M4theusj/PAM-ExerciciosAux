namespace Exercicios;

public partial class Opacidade : ContentPage
{
	public Opacidade()
	{
		InitializeComponent();
	}

    private void OpcSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		BucasImg.Opacity = (int)e.NewValue;
    }
}