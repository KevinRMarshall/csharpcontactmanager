using System;

namespace ContactManager
{
    public class Note
    {
        public string contents { get; private set; } = "";
        public DateTime noteWriteDate { get; private set; }
        

        public Note(string contents)
        {
            noteWriteDate = DateTime.Now;
            this.contents = contents;
        }


        public Note(string noteWriteDate, string contents)
        {
            this.contents = contents;
            this.noteWriteDate = new DateTime(long.Parse(noteWriteDate));
        }


        public override string ToString()
        {
            return $"{noteWriteDate}\r\n{contents}\r\n";
        }
    }
}