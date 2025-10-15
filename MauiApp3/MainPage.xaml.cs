namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

       

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SizerData.Text = "Rozmiar: " + (int)e.NewValue;
            Sizer.FontSize = (int)e.NewValue;
        }
        int id = 0;
        private void CounterBtn_Clicked(object sender, EventArgs e)
        {
            
            string[] witajki = ["Dzień Dobry","Buenos Dias", "Good Morning"];
            if(id > 2)
            {
                id = 0;
                Sizer.Text = witajki[id];
                id += 1;
            } else if (id <= 2)
            {
                
                Sizer.Text = witajki[id];
                id += 1;
            }
        }
    }
}
