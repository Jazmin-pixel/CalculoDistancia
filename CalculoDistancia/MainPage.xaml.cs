namespace CalculoDistancia
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcularClicked(object sender, EventArgs e)
        {
            if (double.TryParse(x1Entry.Text, out double x1) &&
                double.TryParse(y1Entry.Text, out double y1) &&
                double.TryParse(x2Entry.Text, out double x2) &&
                double.TryParse(y2Entry.Text, out double y2))
            {
                double distancia = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

                resultadoLabel.Text = $"Distancia: {distancia:F2}";
            }
            else
            {
                DisplayAlert("Error", "Por favor ingresa números válidos en todas las coordenadas.", "OK");
            }
        }
    }
}
