using SwissTransport.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeinTransportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  .Columns[0].Name = "Luzern";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox1.Items.AddRange(new object[] {"Luzern",
                        "Item 2",
                        "Item 3",
                        "Item 4",
                        "Item 5"});
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var transport = new Transport();
            var connections = transport.GetConnections("Zürich", "Sursee").ConnectionList;

            // dataGridView1 ist ein Objekt.
            // Alle die mit einem Schraubschlüssel neben den Namen sind Eigenschaften von
            // dataGridView1.
            // Also:
            // objekt.Eigenschaft


            foreach(var x in connections)
            {
                // Das hier, dafür haben wir das herausgesucht
                // x.From.Station.Name
                dataGridView1.Rows.Add(new string[]
                {
                    x.From.Station.Name,
                    x.To.Station.Name,
                    x.To.Station.Name,
                    x.To.Station.Name,
                    x.To.Station.Name,
                });
            }

            var myArray = new int[] { 1, 2 };
            foreach (var x in myArray)
            {
                Console.WriteLine(x);
            }

            dataGridView1.Rows.Add(new[]
 {
     comboBox1.Text,
     "Reinach", 
     "Beromünster",
     "Sursee",
     "Menziken",
     // "Luzern",
                
     
     
}) ;
        }
    }
}
