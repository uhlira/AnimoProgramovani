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

            Persons.Add(new Person() { Name = "Karel", BirthDate = DateTime.Parse("10.11.1990") });
            Persons.Add(new Person() { Name = "Hynek", BirthDate = DateTime.Parse("15.04.1991") });
            Persons.Add(new Person() { Name = "Mácha", BirthDate = DateTime.Parse("19.03.1992") });

            /*
            foreach (Person p in Persons)
            {
                lb_Persons.Items.Add(p.Name);
            }
            */

            lb_Persons.DataSource = Persons;

            lbl_Today.Text = DateTime.Now.ToString("D");

            Person selectedPerson = Persons[lb_Persons.SelectedIndex];
            //Person selectedPerson2 = (Person) lb_Persons.SelectedItem;

            lbl_BirthDate.Text = selectedPerson.BirthDate.ToString("d");

        }

        private void lb_Persons_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person selectedPerson = Persons[lb_Persons.SelectedIndex];
            lbl_BirthDate.Text = selectedPerson.BirthDate.ToString("d");
        }
    }
}
