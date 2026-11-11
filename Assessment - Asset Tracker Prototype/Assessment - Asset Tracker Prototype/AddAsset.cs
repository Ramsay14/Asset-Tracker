using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Management;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Assessment___Asset_Tracker_Prototype
{
    public partial class AddAsset : Form
    {
        public AddAsset()
        {
            InitializeComponent();
        }

        public Asset GrabHardwareInfo()
        {
            string SystemName = "Connor's-PC";
            string SystemManufacturer = "Dell Inc.";
            string SystemModel = "OptiPlex 5070";
            string SystemType = "Desktop";
            string IPAddress = "192.168.1.100";

            return new Asset
            {
                systemName = SystemName,
                manufacturer = SystemManufacturer,
                model = SystemModel,
                hardwareType = SystemType,
                IPAddress = IPAddress
            };
        }

        private void GrabEmployeeList()
        {
            try
            {
                const string connectionString =
                    "Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2507934;Persist Security Info=True;User ID=mssql2507934;Password=6ehwx7VQMW;Encrypt=False;Connect Timeout=10";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    const string query =
                        "SELECT employeeID, firstName + ' ' + lastName AS fullName " +
                        "FROM AssetTrackingDB.Employees " +
                        "ORDER BY lastName, firstName";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable employeeTable = new DataTable();
                        adapter.Fill(employeeTable);

                        cmbEmployee.DisplayMember = "fullName";
                        cmbEmployee.ValueMember = "employeeID";
                        cmbEmployee.DataSource = employeeTable;
                        cmbEmployee.SelectedIndex = -1;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Could not retrieve employees from the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddAsset_Load(object sender, EventArgs e)
        {
            txtSystemName.Text = GrabHardwareInfo().systemName;
            txtManufacturer.Text = GrabHardwareInfo().manufacturer;
            txtModel.Text = GrabHardwareInfo().model;
            txtHardwareType.Text = GrabHardwareInfo().hardwareType;
            txtIPAddress.Text = GrabHardwareInfo().IPAddress;
            GrabEmployeeList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employee", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                const string connectionString =
                    "Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2507934;Persist Security Info=True;User ID=mssql2507934;Password=6ehwx7VQMW; Encrypt=False;Connect Timeout=10";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    const string query = 
                        "INSERT INTO AssetTrackingDB.Assets (systemName, manufacturer, model, hardwareType, IPAddress, purchaseDate, notes, employeeID) " +
                        "VALUES (@SystemName, @Manufacturer, @Model, @HardwareType, @IPAddress, @PurchaseDate, @AdditionalNotes, @EmployeeID)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SystemName", txtSystemName.Text);
                        command.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                        command.Parameters.AddWithValue("@Model", txtModel.Text);
                        command.Parameters.AddWithValue("@HardwareType", txtHardwareType.Text);
                        command.Parameters.AddWithValue("@IPAddress", txtIPAddress.Text);
                        command.Parameters.AddWithValue("@PurchaseDate", txtPurchaseDate.Text);
                        command.Parameters.AddWithValue("@AdditionalNotes", txtAdditionalNotes.Text);
                        command.Parameters.AddWithValue("@EmployeeID", cmbEmployee.SelectedValue);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Asset added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add the asset successfully: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPurchaseDate.Text = string.Empty;
            txtAdditionalNotes.Text = string.Empty;
            cmbEmployee.SelectedIndex = -1;

            MessageBox.Show("Asset addition cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
