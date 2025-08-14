
namespace MyFluentMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object? sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(FullNameEntry?.Text))
            {
                await DisplayAlert("Validation", "Full name is required.", "OK");
                return;
            }
            if (!string.IsNullOrWhiteSpace(EmailEntry?.Text) && !EmailEntry.Text.Contains('@'))
            {
                await DisplayAlert("Validation", "Email looks invalid.", "OK");
                return;
            }

            var contact = new Contact
            {
                FullName = FullNameEntry.Text?.Trim() ?? string.Empty,
                Email = EmailEntry.Text?.Trim(),
                Phone = PhoneEntry.Text?.Trim(),
                Company = CompanyEntry.Text?.Trim(),
                Birthday = BirthdayPicker?.Date,
                Category = CategoryPicker?.SelectedItem as string,
                Notes = NotesEditor?.Text
            };

            // For now, just show a confirmation.
            await DisplayAlert("Saved", $"Contact '{contact.FullName}' saved.", "OK");

            // Reset form
            FullNameEntry.Text = string.Empty;
            EmailEntry.Text = string.Empty;
            PhoneEntry.Text = string.Empty;
            CompanyEntry.Text = string.Empty;
            BirthdayPicker.Date = DateTime.Today;
            CategoryPicker.SelectedIndex = -1;
            NotesEditor.Text = string.Empty;
        }

        private async void DeleteBtn_ClickedAsync(object? sender, EventArgs e)
        {
            var result = await DisplayAlert("Confirm Delete", "Are you sure you want to delete this contact?", "Yes", "No");
            System.Diagnostics.Debug.WriteLine($"Delete confirmation result: {result}");
        }
    }
}
