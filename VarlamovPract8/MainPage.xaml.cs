namespace VarlamovPract8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoadPhoto(object sender, EventArgs e)
        {

        }



        private void stepperAvgRate_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Rate.Text = stepperAvgRate.Value.ToString();
            Rate.Text = e.NewValue.ToString();
        }
    }
}