using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    public class Record
    {
        DateTime recordTime;
        public DateTime RecordTime // { get; set; }
        {
            get 
            { 
                return recordTime; 
            }

            set 
            { 
                if(DateTime.Now - value < new TimeSpan(0, 5, 0))
                    recordTime = value; 
            }
        }

        string title;
        public string Title
        {
            get { return title; }

            set
            {
                if (value.Length < 50)
                    title = value;
                else throw new Exception("Too much chars");
            }
        }

        string text;
        public string Text 
        {
            get { return text; }

            set
            {
                if (value.Length < 50000)
                {
                    text = value;
                }
                
                
            }
        }

        string autor;
        public string Autor
        {
            get { return autor; }

            set
            {
                if (value.Length < 200)
                    autor = value;
            }
        }

        public override bool Equals(object obj)
        {
            Record r = obj as Record;

            if (r != null) 
            {
                return Title == r.Title && Text == r.Text && Autor == r.Autor && RecordTime == r.RecordTime;
            }

            return false;
        }

        public override string ToString()
        {
            return RecordTime.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "\t" +
                Autor + "\t" +
                Title + "\t" +
                Text;
        }

    }
}
