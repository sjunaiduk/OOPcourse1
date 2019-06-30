using CarApplication.entitites;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApplication
{
    public partial class Form1 : Form
    {

        public ArrayList VEHICLES = new ArrayList();

      


        public Form1()
        {
            InitializeComponent();
        }

 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string make = this.txtMake.Text;
            string colour = this.txtColour.Text;
            string type = this.cmbType.Text;
            string model = this.txtModel.Text;

            Vehicle myVehicle = null;

            if (type == "Car")
            {
                myVehicle = new Car();
   

            }
            else if (type == "Truck")
            {
                myVehicle = new Truck();
  
            }
            else if (type == "Motorcycle")
            {
                myVehicle = new Motorcycle();

            }


            myVehicle.Make = make;
            myVehicle.Colour = colour;
            myVehicle.Model = model;
            VEHICLES.Add(myVehicle);


        }

        private void btnShow_Click(object sender, EventArgs e)

        {
            listBoxVehicles.Items.Clear();
            foreach(Vehicle o in VEHICLES)
            {
                   
                    string text = o.CalculatePrice()+ " "+o.Make+" "+o.Model+" "+o.Type+"  is of color "+ o.Colour;
                    listBoxVehicles.Items.Add(text);
           
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            listBoxVehicles.Items.Clear();
            VEHICLES = new ArrayList();
        }
    }
}
