﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Tittle");
            table.Columns.Add("Message");

            dataGridView1.DataSource = table;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
                int index = dataGridView1.CurrentCell.RowIndex;
                if (index > -1)
                {
                    textBox1.Text = table.Rows[index].ItemArray[0].ToString();
                    textBox2.Text = table.Rows[index].ItemArray[1].ToString();
                }
         
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index=dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete(); 
        }
    }
}
