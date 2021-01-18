﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRecord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComputerScience_Click(object sender, EventArgs e)
        {
            SampleDataContext db = new SampleDataContext();
            dataGridView1.DataSource = db.EngineeringStudents.OfType<CSE>().ToList();
        }

        private void Electronics_Click(object sender, EventArgs e)
        {
            SampleDataContext db = new SampleDataContext();
            dataGridView1.DataSource = db.EngineeringStudents.OfType<ECE>().ToList();

        }

        private void Electrical_Click(object sender, EventArgs e)
        {
            SampleDataContext db = new SampleDataContext();
            dataGridView1.DataSource = db.EngineeringStudents.OfType<EEE>().ToList();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {

            

        }
    }
}
