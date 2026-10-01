namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void Polub(Object sender, EventArgs e)
        {
            count++;
            polubienia.Text = count.ToString() + " Polubień";
        }

        public void Usun(Object sender, EventArgs e)
        {
            if(count > 0)
            {
                count--;
                polubienia.Text = count.ToString() + " Polubień";
            }
        }

        private void Polub_Clicked(object sender, EventArgs e)
        {

        }
    }
}
