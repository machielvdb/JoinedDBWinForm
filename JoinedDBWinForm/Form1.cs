using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoinedDBWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void FillListBox()
        {
            using (JoinedDBEntities ctx = new JoinedDBEntities())
            {
                var query = ctx.Persoons.Select(x => x).ToList();

                lbPersonen.DisplayMember = "Voornaam";
                lbPersonen.ValueMember = "Id";
                lbPersonen.DataSource = query;
            }
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            var origineelPersoon = lbPersonen.SelectedItem as Persoon;


        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            Persoon nieuwPersoon = new Persoon();
            nieuwPersoon.Voornaam = tbVoornaam.Text;
            nieuwPersoon.Achternaam = tbAchternaam.Text;
            nieuwPersoon.Leeftijd = int.Parse(tbLeeftijd.Text);
            nieuwPersoon.Id = int.Parse(tbBadge.Text);

            SaveToDB(nieuwPersoon);
            FillListBox();
        }

        private void SaveToDB(Persoon NieuwPersoon)
        {
            using (JoinedDBEntities ctx = new JoinedDBEntities())
            {
                ctx.Persoons.Add(NieuwPersoon);
                ctx.SaveChanges();
            }
        }

        private void SaveToDB(Persoon NieuwPersoon, Persoon OrigineelPersoon)
        {
            using (JoinedDBEntities ctx = new JoinedDBEntities())
            {
                ctx.Persoons.
            }
        }

        private void lbPersonen_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPerson = lbPersonen.SelectedItem as Persoon;
            tbVoornaam.Text = selectedPerson.Voornaam;
            tbAchternaam.Text = selectedPerson.Achternaam;
            tbLeeftijd.Text = selectedPerson.Leeftijd.ToString();
            tbBadge.Text = selectedPerson.Id.ToString();
        }
    }
}
