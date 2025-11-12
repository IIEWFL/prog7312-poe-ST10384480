using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MunicipalServiceApplication.Data;
using MunicipalServiceApplication.Models;

namespace MunicipalServiceApplication.Forms
{
    public partial class EventsForm : Form
    {
        private SortedDictionary<DateTime, Event> eventsDict;
        private HashSet<string> categories;
        private Stack<string> recentSearches;

        public EventsForm()
        {
            InitializeComponent();

            eventsDict = FakeDatabase.GetSortedEvents();
            categories = new HashSet<string>(eventsDict.Values.Select(e => e.Category));
            recentSearches = new Stack<string>();

            LoadEvents();
            LoadCategories();
        }

        private void LoadEvents()
        {
            lstEvents.Items.Clear();
            foreach (var ev in eventsDict.Values)
            {
                lstEvents.Items.Add($"{ev.Date:dd/MM/yyyy} - {ev.Title} ({ev.Category})");
            }
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            foreach (var cat in categories)
            {
                cmbCategory.Items.Add(cat);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.Text.Trim();
            string dateText = txtDate.Text.Trim();

            recentSearches.Push(selectedCategory);

            var filtered = eventsDict.Values.AsEnumerable();

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                filtered = filtered.Where(ev => ev.Category.Equals(selectedCategory, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(dateText))
            {
                if (DateTime.TryParseExact(dateText, "dd/MM/yyyy", CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out DateTime parsedDate))
                {
                    filtered = filtered.Where(ev => ev.Date.Date == parsedDate.Date);
                }
                else
                {
                    MessageBox.Show("Invalid date format. Use dd/MM/yyyy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            lstEvents.Items.Clear();
            foreach (var ev in filtered)
            {
                lstEvents.Items.Add($"{ev.Date:dd/MM/yyyy} - {ev.Title} ({ev.Category})");
            }

            ShowRecommendations(selectedCategory);
        }

        private void ShowRecommendations(string category)
        {
            lblRecommendation.Text = "Recommended events:\n";

            var recommended = eventsDict.Values
                .Where(ev => !string.IsNullOrEmpty(category) && ev.Category != category)
                .Take(3);

            foreach (var ev in recommended)
            {
                lblRecommendation.Text += $"{ev.Title} ({ev.Category})\n";
            }
        }
    }
}