using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;

namespace Maui_Application
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
            DisplayRandomQuote();
        }
        private void OnDarkModeToggled(object sender, ToggledEventArgs e)
        {
            App.Current.UserAppTheme = e.Value ? AppTheme.Dark : AppTheme.Light;
        }
        private void DisplayRandomQuote()
        {
           string[] quotes = {
            "Do or do not, there is no try. - Yoda",
            "In the middle of difficulty lies opportunity. - Albert Einstein",
            "The only limit to our realization of tomorrow will be our doubts of today. - Franklin D. Roosevelt",
            "Strive not to be a success, but rather to be of value. - Albert Einstein",
            "The only way to do great work is to love what you do. - Steve Jobs",
            "Success is not final, failure is not fatal: It is the courage to continue that counts. - Winston Churchill",
            "The only person you are destined to become is the person you decide to be. - Ralph Waldo Emerson",
            "Believe you can and you're halfway there. - Theodore Roosevelt",
            "Your time is limited, don't waste it living someone else's life. - Steve Jobs",
            "Strive for greatness, not for power. - William Arthur Ward",
            "It's not about how hard you hit. It's about how hard you can get hit and keep moving. - Rocky Balboa",
            "The future belongs to those who believe in the beauty of their dreams. - Eleanor Roosevelt",
            "Success is stumbling from failure to failure with no loss of enthusiasm. - Winston Churchill",
            "The only place where success comes before work is in the dictionary. - Vidal Sassoon",
            "Don't watch the clock; do what it does. Keep going. - Sam Levenson",
            "I find that the harder I work, the more luck I seem to have. - Thomas Jefferson",
            "The only impossible journey is the one you never begin. - Tony Robbins",
            "Believe in yourself and all that you are. Know that there is something inside you that is greater than any obstacle. - Christian D. Larson",
            "Don't be pushed around by the fears in your mind. Be led by the dreams in your heart. - Roy T. Bennett",
            "Challenges are what make life interesting. Overcoming them is what makes life meaningful. - Joshua J. Marine"
           };

            Random random = new Random();
            string randomQuote = quotes[random.Next(quotes.Length)];

            QuoteLabel.Text = randomQuote;
        }
    }
}