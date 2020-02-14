using App1.Models;
using System;
using System.IO;
using Xamarin.Forms;

namespace App1
{
    public partial class NoteEntryPage : ContentPage
    {
        public NoteEntryPage()
        {
            InitializeComponent();
            NoteEntryPageContentPage.Title = "Nota del " + "sii";
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            note.Date = DateTime.UtcNow;
            await App.Database.SaveNoteAsync(note);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync();
        }
    }
}