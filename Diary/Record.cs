using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public class Diary
    {
        private List<Record> records;
        public List<Record> Records 
        {
            get 
            {
                return new List<Record>(records);
            }
            private set 
            {
                records = value;
            } 
        }

        public Diary()
        {
            this.Records = new List<Record>();
        }

        public void Save() 
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "diary.txt");
            File.WriteAllText(path, JsonConvert.SerializeObject(this.records));
        }

        public void Load() 
        {

        }

        public void Add(Record record)
        {
            Record rempty = new Record()
            {
                RecordTime = DateTime.Now,
                Title = string.Empty,
                Text = string.Empty,
                Autor = string.Empty
            };

            if (!record.Equals(rempty))
                records.Add(record);
        }
    }
}
