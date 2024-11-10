namespace WinFS_DZ_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlanTrip_Click(object sender, EventArgs e)
        {
            if (dateTimePickerEnd.Value < dateTimePickerStart.Value)
            {
                MessageBox.Show("���� ���������� �� ���� ���� ����� ���� �������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string transport = "";
            if (radioButtonPlane.Checked)
                transport = "˳���";
            else if (radioButtonTrain.Checked)
                transport = "����";
            else if (radioButtonBus.Checked)
                transport = "�������";

            string services = "";
            if (checkBoxInsurance.Checked)
                services += "���������, ";
            if (checkBoxExcursions.Checked)
                services += "�������, ";
            if (checkBoxExtraLuggage.Checked)
                services += "���������� �����, ";
            if (services.EndsWith(", "))
                services = services.Substring(0, services.Length - 2);

            string destination = comboBoxDestination.SelectedItem?.ToString() ?? "�� �������";

            string summary = $"���� �������: {dateTimePickerStart.Value.ToShortDateString()}\n" +
                             $"���� ����������: {dateTimePickerEnd.Value.ToShortDateString()}\n" +
                             $"���������: {transport}\n" +
                             $"̳��� �����������: {destination}\n" +
                             $"�������� �������: {services}";

            textBoxSummary.Text = summary;
        }
    }
}
