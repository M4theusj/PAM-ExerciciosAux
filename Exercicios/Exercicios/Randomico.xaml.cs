namespace Exercicios
{
    public partial class Randomico : ContentPage
    {
        Random rand = new Random();
        int randomNumber;

        public Randomico()
        {
            InitializeComponent();
            randomNumber = rand.Next(1, 101); 
        }

        public void ConfirmGuess_Clicked(object sender, EventArgs e)
        {
            int guess;

            if (!int.TryParse(EntryGuess.Text, out guess))
            {
                DisplayAlert("Erro", "Por favor, insira um número válido.", "OK");
                return;
            }

            if (guess > randomNumber)
            {
                DisplayAlert("Errado", "O número é menor.", "Tentar novamente");
            }
            else if (guess < randomNumber)
            {
                DisplayAlert("Errado", "O número é maior.", "Tentar novamente");
            }
            else
            {
                DisplayAlert("Correto", "Você acertou!", "Eba");
            }
        }
    }
}