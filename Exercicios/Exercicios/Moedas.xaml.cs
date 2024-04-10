namespace Exercicios;

public partial class Moedas : ContentPage
{
	public Moedas()
	{
        InitializeComponent();
	}

    private void DolarCoin_Clicked(object sender, EventArgs e)
    {
        double Valor = Convert.ToDouble(RealCoin.Text);
        Valor = Valor * 0.20;
        ConvCoin.Text = Valor.ToString();

    }

    private void IeneCoin_Clicked(object sender, EventArgs e)
    {
        double Valor = Convert.ToDouble(RealCoin.Text);
        Valor = Valor * 30.30;
        ConvCoin.Text = Valor.ToString();
    }

    private void EuroCoin_Clicked(object sender, EventArgs e)
    {
        double Valor = Convert.ToDouble(RealCoin.Text);
        Valor = Valor * 0.18;
        ConvCoin.Text = Valor.ToString();
    }

    private void Libra_Clicked(object sender, EventArgs e)
    {
        double Valor = Convert.ToDouble(RealCoin.Text);
        Valor = Valor * 0.16;
        ConvCoin.Text = Valor.ToString();
    }
}