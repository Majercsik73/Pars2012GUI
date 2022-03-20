using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Pars2012GUI
{
    public partial class Form1 : Form
    {
        static List<Versenyzo> versenyzo = new List<Versenyzo>();
        
        public Form1()
        {

            string[] teljesSelejtezo = File.ReadAllLines("../../../Selejtezo2012.txt");

            for (int i = 1; i < teljesSelejtezo.Length; i++)
            {
                versenyzo.Add(new Versenyzo(teljesSelejtezo[i]));
            }
            InitializeComponent();
            foreach (var i in versenyzo)
            {
                cBoxNev.Items.Add(i.nev);
                if (i.nev == "Pars Krisztián") cBoxNev.SelectedItem = i.nev;
            }

        }

        private void cBoxNev_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            Versenyzo aktualis = versenyzo[cb.SelectedIndex];
            labCsoport.Text= $"Csoport: {aktualis.csoport}";
            labNemzet.Text = $"Nemzet: {aktualis.Nemzet}";
            labNemKod.Text = $"Nemzet kód: {aktualis.Kod}";
            labSorozat.Text = $"Sorozat: {aktualis.sorozat}";
            labEredmeny.Text = $"Eredmény: {aktualis.Eredmeny}";
            picBoxZaszlo.ImageLocation = "../../../Images/" + aktualis.Kod + ".png";
        }
    }
}
