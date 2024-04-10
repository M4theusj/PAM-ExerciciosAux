namespace Exercicios;

public partial class Temperatura : ContentPage
{
	public Temperatura()
	{
		InitializeComponent();
	}

    private void CelsiusSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		int celsius = (int)e.NewValue;
        CelsiusLabel.Text = celsius.ToString();

        FarenTemp.Text = $"Temperatura em Fahrenheit: {(celsius * 9/5) + 32}";
		KelvinTemp.Text = $"Temperatura em Kelvin: {celsius + 273}";
    }

}