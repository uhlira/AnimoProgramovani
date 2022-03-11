using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCalculator
{
    public partial class Form1 : Form
    {
        List<Person> Persons { get; set; }

        public Form1()
        {
            InitializeComponent();

            Persons = new List<Person>();

            Persons.Add(new Person() { Name = "Karel", BirthDate = DateTime.Parse("03.02.2012") });
            Persons.Add(new Person() { Name = "Hynek", BirthDate = DateTime.Parse("04.02.2012") });
            Persons.Add(new Person() { Name = "Mácha", BirthDate = DateTime.Parse("05.02.2012") });

            /*
            foreach (Person p in Persons)
            {
                lb_Persons.Items.Add(p.Name);
            }
            */

            lb_Persons.DataSource = Persons;
            lbl_Today.Text = DateTime.Now.ToString("D");
            lbl_NearestBDay.Text = NearestBirthday();

            UpdatePersonInfo();
        }

        private void lb_Persons_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePersonInfo();
        }

        private void UpdatePersonInfo() 
        {
            Person selectedPerson = Persons[lb_Persons.SelectedIndex];
            //Person selectedPerson2 = (Person) lb_Persons.SelectedItem;
            lbl_BirthDate.Text = selectedPerson.BirthDate.ToString("d");

            /*
            int age = DateTime.Now.Year - selectedPerson.BirthDate.Year;
            if (DateTime.Today < selectedPerson.BirthDate.AddYears(age))
            {
                age--;
            }
            lbl_Age.Text = age.ToString();
            */

            lbl_Age.Text = AgeInYears(selectedPerson.BirthDate, DateTime.Now).ToString();
        }

        private string NearestBirthday() 
        {
            List<int> timeToBDays = new List<int>();

            foreach (Person p in Persons)
            {
                timeToBDays.Add((int)(p.BirthDate.AddYears(DateTime.Now.Year + 1) - DateTime.Now).TotalDays);
            }

            return timeToBDays.Where(x => x == timeToBDays.Min()).FirstOrDefault().ToString();
        }

        public static double AgeInYears(DateTime birthday, DateTime today)
        {
            return ((today.Year - birthday.Year) * 24 + (today.Month - birthday.Month) * 2 + (today.Day - birthday.Day)) / 24;
        }
    }
}
