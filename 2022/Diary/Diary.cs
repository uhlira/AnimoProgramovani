using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Diary
{
    public class Diary
    {
        public static int StaticNumber;

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
            this.records = new List<Record>();
        }

        public void Save()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "diary.txt");
            File.WriteAllText(path, JsonConvert.SerializeObject(this.records, Formatting.Indented), Encoding.UTF8);
        }

        public void Load()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "diary.txt");
            this.records = JsonConvert.DeserializeObject<List<Record>>(File.ReadAllText(path));
        }

        public void Add(Record record)
        {
            Console.WriteLine(record.ToString());
            Console.WriteLine(record.Text.Length);
            //MessageBox

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
