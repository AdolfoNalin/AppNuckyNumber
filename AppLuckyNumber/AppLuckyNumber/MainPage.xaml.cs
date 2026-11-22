namespace AppLuckyNumber;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnGenerationLuckyNumber(object sender, EventArgs e)
    {
        try
        {
            lblLuckyNumberTitle.IsVisible = false;
            ContainerLuckyNumber.IsVisible = true;
            SortedSet<int> luckyNumbers = GenerationLuckyNumber();

            LuckyNumber01.Text = luckyNumbers.ElementAt(0).ToString("D2");
            LuckyNumber02.Text = luckyNumbers.ElementAt(1).ToString("D2");
            LuckyNumber03.Text = luckyNumbers.ElementAt(2).ToString("D2");
            LuckyNumber04.Text = luckyNumbers.ElementAt(3).ToString("D2");
            LuckyNumber05.Text = luckyNumbers.ElementAt(4).ToString("D2");
            LuckyNumber06.Text = luckyNumbers.ElementAt(5).ToString("D2");
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "Fechar");
        }
    }

    private SortedSet<int> GenerationLuckyNumber()
    {
        try
        {
            SortedSet<int> luckyNumbers = new SortedSet<int>();
            while (luckyNumbers.Count < 6)
            {
                var randon = new Random();
                int luckNumber = randon.Next(1, 60);
                luckyNumbers.Add(luckNumber);
            }

            return luckyNumbers;
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "Fechar");
            return null;
        }
    }
}