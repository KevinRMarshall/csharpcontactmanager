using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ContactManager
{
    public class Contact
    {
        public string FirstName = "";
        public string LastName = "";
        public string AddressType = "";
        public string Street = "";
        public string City = "";
        public string Province = "";
        public string Zip = "";
        public string Email = "";
        public string EmailType = "";
        public string Phone = "";
        public string PhoneType = "";
        private string notesFilePath = "";
        public string PhotoPath = "";

        public List<Note> Notes { get; private set; } = new List<Note>();


        public void AddNote(string contents)
        {
            Note note = new Note(contents);
            Notes.Add(note);

            SaveNotes();
        }


        public void LoadDataFromString(string raw)
        {
            string[] data = raw.Split('|');
            FirstName = data[0];
            LastName = data[1];
            AddressType = data[2];
            Street = data[3];
            City = data[4];
            Province = data[5];
            Zip = data[6];
            Email = data[7];
            EmailType = data[8];
            Phone = data[9];
            PhoneType = data[10];
            notesFilePath = data[11];
            PhotoPath = data[12];

            if (File.Exists(notesFilePath))
            {
                foreach (string noteData in File.ReadAllLines(notesFilePath))
                {
                    string[] noteValues = noteData.Split('|');
                    Note note = new Note(noteValues[0], noteValues[1]);
                    Notes.Add(note);
                }
            }
        }


        public string NotesChronological()
        {
            Notes.Reverse();
            StringBuilder output = new StringBuilder();

            foreach (Note note in Notes)
            {
                output.AppendLine(note.ToString());
            }

            Notes.Reverse();
            return output.ToString();
        }


        private void SaveNotes()
        {
            using (StreamWriter writer = new StreamWriter(notesFilePath))
            {
                foreach(Note note in Notes)
                {
                    writer.WriteLine($"{note.noteWriteDate.Ticks}|{note.contents}");
                }
            }
        }


        public string ToSaveString()
        {
            if (string.IsNullOrWhiteSpace(notesFilePath))
            {
                notesFilePath = Environment.CurrentDirectory + $"\\{FirstName[0]}{LastName[0]}{DateTime.Now.Ticks}.txt";
            }
            return $"{FirstName}|{LastName}|{AddressType}|{Street}|{City}|{Province}|{Zip}" +
                $"|{Email}|{EmailType}|{Phone}|{PhoneType}|{notesFilePath}|{PhotoPath}";
        }


        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}