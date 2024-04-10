namespace Exercicios;

public partial class Calculadora : ContentPage
{
	public Calculadora()
	{
		InitializeComponent();
	}

    private void Adicao_Clicked(object sender, EventArgs e)
    {
        double ValorUm = Convert.ToDouble(CalcEntry.Text);
        double ValorDois = Convert.ToDouble(CalcEntry2.Text);
        double Total = ValorUm + ValorDois;

        Result.Text = $"Resultado: {Total.ToString()}";
    }

    private void Subtracao_Clicked(object sender, EventArgs e)
    {
        double ValorUm = Convert.ToDouble(CalcEntry.Text);
        double ValorDois = Convert.ToDouble(CalcEntry2.Text);
        double Total = ValorUm - ValorDois;

        Result.Text = $"Resultado: {Total.ToString()}";
    }

    private void Multiplicacao_Clicked(object sender, EventArgs e)
    {
        double ValorUm = Convert.ToDouble(CalcEntry.Text);
        double ValorDois = Convert.ToDouble(CalcEntry2.Text);
        double Total = ValorUm * ValorDois;

        Result.Text = $"Resultado: {Total.ToString()}";
    }

    private void Divisao_Clicked(object sender, EventArgs e)
    {
        double ValorUm = Convert.ToDouble(CalcEntry.Text);
        double ValorDois = Convert.ToDouble(CalcEntry2.Text);
        double Total = ValorUm / ValorDois;

        Result.Text = $"Resultado: {Total.ToString()}";
    }
}