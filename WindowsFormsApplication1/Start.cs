using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QualityVehicleCars;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace QualityVehicleForms
{

    public partial class Start : Form
    {
        public static CarYard carYard = new CarYard();
        
        public Start()
        {
            InitializeComponent();
            carYard.employees.Add(new Employee("123 Street", "123pass", 123, Role.admin, "MainAdmin", "345 Street, Auckland", new DateTime(1970, 10, 10), 345643, "John", 126789));

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeLogin employeeLoginform = new EmployeeLogin();
            employeeLoginform.Closed += (s, args) => this.Show();
            employeeLoginform.Show();
        }

        //The methods added below are to save the car yard even after closing the application.

        public static void RestoreCarYard()
        {
            try
            {
                
                Console.WriteLine("The file already exists!");
                using (FileStream fStream = new FileStream("../../TestStore.bin", FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(fStream))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        CarYard obj = (CarYard)formatter.Deserialize(fStream);
                        Start.carYard = obj;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error loading the saved data.");
            }
        }

        public static void SaveCarYard()
        {
            try
            {
                using (FileStream isoStream = new FileStream("../../TestStore.bin", FileMode.Create))
                {
                    using (StreamWriter writer = new StreamWriter(isoStream))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(isoStream, Start.carYard);

                        Debug.WriteLine("You have written to the file.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error saving.");
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {
            RestoreCarYard();
        }
    }
}
