
using DataLibrary.DAO;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        Data data = new Data();

        public Form1()
        {
            InitializeComponent();
            PeopleList();
        }

        private void PeopleList()
        {
            List<Person> list = data.ReadAll();
            dataList.DataSource = list;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            lblErro.Text = "";

            string name = textBoxName.Text;
            string lastName = textBoxLastName.Text;
            string cpf = textBoxCPF.Text;

            if (ValidaFormulario(name, lastName, cpf))
            {
                Person person = new Person();
                person.Name = name;
                person.LastName = lastName;
                person.CPF = cpf;
               
                data.ToSave(person);

                Clear();
                lblSuccess.Text = " Saved successfully.";
                PeopleList();
            }
        }

        private bool ValidaFormulario(string name, string lastName, string cpf)
        {

            bool valid = true;

            if (name.Trim() == "")
            {
                valid = false;
                lblErro.Text = " Name was not filled in.";
            }
            if (lastName.Trim() == "")
            {
                valid = false;
                lblErro.Text += " Last Name was not filled in.";
            }
            if (cpf.Trim() == "")
            {
                valid = false;
                lblErro.Text += " CPF was not filled in.";
            }

            return valid;
        }
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            textBoxName.Clear();
            textBoxLastName.Clear();
            textBoxCPF.Clear();
        }
    }
}
