using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entry_Exit_Registration_System
{
    public partial class UserControl_ReleaseEmployee : UserControl
    {
        private static UserControl_ReleaseEmployee _instance;
        private DatabaseManager database;
        private int counter = 0;

        public static UserControl_ReleaseEmployee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl_ReleaseEmployee();
                }
                return _instance;
            }
        }

        public UserControl_ReleaseEmployee()
        {
            InitializeComponent();
        }

        private void UserControl_ReleaseEmployee_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            database = DatabaseManager.Instance;

            this.ActiveControl = dataGridView_employees;

            employee_lable.Text = "Премахване на служител";
            employee_removed.Text = "Служителят/лите е премахнат!";
            employee_removed.Visible = false;
            release_employrr_button.Text = "Премахни служител";

            position_lable.Text = "Премахване на позиция";
            position_removed.Text = "Позицията/те е премахната";
            position_removed.Visible = false;
            remove_position_button.Text = "Премахни позиция";

            dataGridViewRefresh();
        }

        private void timer_removed_lable_Tick(object sender, EventArgs e)
        {
            ++counter;

            if (counter == 15)
            {
                timer_removed_lable.Stop();
                employee_removed.Visible = false;
                position_removed.Visible = false;
                counter = 0;
            }
        }

        public void dataGridViewRefresh()
        {
            dataGridView_employees.Rows.Clear();
            dataGridView_positions.Rows.Clear();
            int index = 1;

            List<CheckInEvent> employees = database.GetEmployees();
            if (employees != null && employees.Count > 0) {
                foreach (CheckInEvent employee in employees)
                {
                    dataGridView_employees.Rows.Add(employee.F_Name, employee.L_Name, employee.EGN, employee.Position_Name);
                }
                dataGridView_employees.Rows[0].Selected = false;
            }

            List<String> positions = database.GetPositionNames();
            if (positions.Count > 0)
            {
                foreach (String position in positions)
                {
                    dataGridView_positions.Rows.Add(index++, position);
                }
                dataGridView_positions.Rows[0].Selected = false;
            }
        }

        private void release_employrr_button_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dataGridView_employees.GetCellCount(DataGridViewElementStates.Selected) / 4;
            if (selectedCellCount > 0)
            {
                if (dataGridView_employees.AreAllCellsSelected(true) && selectedCellCount > 1)
                {
                    DialogResult result = MessageBox.Show("Избрали сте всички служители.\nСигурни ли сте, че искате да ги премахнете?", "Предопреждение!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dataGridView_employees.Rows)
                        {
                            database.RemoveEmployee(row.Cells["id"].Value.ToString());
                        }
                        employee_removed.Visible = true;
                        timer_removed_lable.Start();
                    }
                    else if (result == DialogResult.No)
                    {
                        dataGridView_employees.ClearSelection();
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView_employees.SelectedRows)
                    {
                        database.RemoveEmployee(row.Cells["id"].Value.ToString());
                    }
                    employee_removed.Visible = true;
                    timer_removed_lable.Start();
                }
            }
            else
            {
                MessageBox.Show("Моля изберете служител/ли за премахване.", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridViewRefresh();
            this.ActiveControl = dataGridView_employees;
        }

        private void remove_position_button_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dataGridView_positions.GetCellCount(DataGridViewElementStates.Selected) / 2;
            if (selectedCellCount > 0)
            {
                if (dataGridView_positions.AreAllCellsSelected(true) && selectedCellCount > 1)
                {
                    DialogResult result = MessageBox.Show("Избрали сте всички позиции.\nСигурни ли сте, че искате да ги премахнете?", "Предопреждение!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dataGridView_positions.Rows)
                        {
                            database.RemovePosition(row.Cells["name"].Value.ToString());
                        }
                        position_removed.Visible = true;
                        timer_removed_lable.Start();
                    }
                    else if (result == DialogResult.No)
                    {
                        dataGridView_positions.ClearSelection();
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView_positions.SelectedRows)
                    {
                        database.RemovePosition(row.Cells["name"].Value.ToString());
                    }
                    position_removed.Visible = true;
                    timer_removed_lable.Start();
                }
            }
            else
            {
                MessageBox.Show("Моля изберете позиция/й за премахване.", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridViewRefresh();
            this.ActiveControl = dataGridView_positions;
        }
    }
}
