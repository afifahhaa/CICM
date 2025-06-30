using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace CICMmauiApp.View
{
    public partial class IssuesPage : ContentPage
    {
        private readonly HttpClient _httpClient;

        public IssuesPage()
        {
            //InitializeComponent();
            _httpClient = new HttpClient();
            _ = LoadIssues();
        }

        public object IssuesCollectionView { get; private set; }

        private async Task LoadIssues()
        {
            try
            {
                var issues = await _httpClient.GetFromJsonAsync<List<Issue>>("http://localhost:5000/api/cicm/issuelisting");
                //if (issues != null)
                //{
                //    IssuesCollectionView.ItemSource = issues; // Bind issues to the CollectionView
                //}
                //else
                //{
                //    await DisplayAlert("No Data", "No issues found.", "OK");
                //}
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error fetching issues: {ex}");
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
        }

        private async void OnRefreshClicked(object sender, EventArgs e)
        {
            await LoadIssues(); // Refresh the issue list
        }
    }

    public class Issue
    {
        public Int64 IssueID { get; set; }

        public required string IssueRefNo { get; set; }

        public required string TicketNo { get; set; }
        public DateTime IssueDate { get; set; }

        public Int64 ProductID { get; set; }

        public Int64 SeverityID { get; set; }

        public DateTime FirstDueDate { get; set; }

        public DateTime DueDate { get; set; }
        public required string DueDateCheckFlag { get; set; }


        public decimal ResponseTime { get; set; }

        public byte ResponseLevel { get; set; }

        public DateTime? ClosedDate { get; set; }

        public DateTime? ReopenDate { get; set; }

        public required string Urgency { get; set; }

        public required string Status { get; set; }

        public Int64 Created_By { get; set; }

    }
}