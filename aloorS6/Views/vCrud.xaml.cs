using System.Collections.ObjectModel;
using aloorS6.Model;
using Newtonsoft.Json;

namespace aloorS6.Views;

public partial class vCrud : ContentPage
{
	private const string URL = "http://localhost:9090/api/booking/all";
	private readonly HttpClient cliente = new HttpClient();
	private ObservableCollection<Booking> booking;

    public vCrud()
	{
		InitializeComponent();
		mostrarBookin();
	}

	public async void mostrarBookin()
	{
		var content = await cliente.GetStringAsync(URL);
		List<Booking> lista = JsonConvert.DeserializeObject<List<Booking>>(content);
		booking = new ObservableCollection<Booking>(lista);
		lvEstudiantes.ItemsSource = booking;
	}
}