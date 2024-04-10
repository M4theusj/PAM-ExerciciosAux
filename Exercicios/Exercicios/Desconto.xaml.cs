namespace Exercicios;

public partial class Desconto : ContentPage
{
	public Desconto()
	{
		InitializeComponent();
	}

    private void ValorProduto_TextChanged(object sender, TextChangedEventArgs e)
    {
        ProductValue.Text = $"Valor do produto: {ValorProduto.Text}";

    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        int desconto = (int)e.NewValue;
        if(double.TryParse(ValorProduto.Text, out double produto))
        { 

        SliderValor.Text = $"Valor do desconto: {desconto.ToString()}";

        TotalValue.Text = (produto * desconto / 100).ToString();

        }

    }
}