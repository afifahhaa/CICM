namespace CICMmauiApp
{
    internal class LoginPage
    {
        private readonly DataService _dataService;

        public LoginPage()
        {
            //InitializeComponent();
            LoadData();



        }
        void LoadData()
        {
            async void LoadData(object sender, EventArgs e)
            {
                try
                {
                    string apiUrl = "http://localhost:5000/api/cicm/issuelisting"; // Replace with your API URL
                    var items = await _dataService.GetItemsAsync(apiUrl);
                }
                catch (Exception ex)
                {

                }

                //MyListView.ItemsSource = items; // Assuming you have a ListView named
            }
        }
    }
}