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



            if (type == "Car")
            {
                Car mycar = new Car();
                mycar.Make = make;
                mycar.Colour = colour;
                mycar.Model = model;
                VEHICLES.Add(mycar);

            }
            else if (type == "Truck")
            {
                Truck mytruck = new Truck();
                mytruck.Make = make;
                mytruck.Colour = colour;
                mytruck.Model = model;
                VEHICLES.Add(mytruck);
            }
            else if (type == "Motorcycle")
            {
                Motorcycle mytruck = new Motorcycle();
                mytruck.Make = make;
                mytruck.Colour = colour;
                mytruck.Model = model;
                VEHICLES.Add(mytruck);
            }


        }

        private void btnShow_Click(object sender, EventArgs e)

        {
            listBoxVehicles.Items.Clear();
            foreach(Object o in VEHICLES)
            {
                if (o.GetType().Name == "Car")
                {
                    Car mycar = o as Car;
                    string text = mycar.Make+" "+mycar.Model+" "+mycar.Type+"  is of color "+ mycar.Colour;
                    listBoxVehicles.Items.Add(text);
                    
                }
                else if (o.GetType().Name == "Truck")
                {
                    Truck mycar = o as Truck;
                    string text = mycar.Make + " " + mycar.Model + " " + mycar.Type + "  is of color " + mycar.Colour;
                    listBoxVehicles.Items.Add(text);

                }
                else if (o.GetType().Name == "Motorcycle")
                {
                    Motorcycle mycar = o as Motorcycle;
                    string text = mycar.Make + " " + mycar.Model + " " + mycar.Type + "  is of color " + mycar.Colour;
                    listBoxVehicles.Items.Add(text);

                }
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
