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
                MessageBox.Show("Дата завершення не може бути раніше дати початку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string transport = "";
            if (radioButtonPlane.Checked)
                transport = "Літак";
            else if (radioButtonTrain.Checked)
                transport = "Поїзд";
            else if (radioButtonBus.Checked)
                transport = "Автобус";

            string services = "";
            if (checkBoxInsurance.Checked)
                services += "Страховка, ";
            if (checkBoxExcursions.Checked)
                services += "Екскурсії, ";
            if (checkBoxExtraLuggage.Checked)
                services += "Додатковий багаж, ";
            if (services.EndsWith(", "))
                services = services.Substring(0, services.Length - 2);

            string destination = comboBoxDestination.SelectedItem?.ToString() ?? "не вибрано";

            string summary = $"Дата початку: {dateTimePickerStart.Value.ToShortDateString()}\n" +
                             $"Дата завершення: {dateTimePickerEnd.Value.ToShortDateString()}\n" +
                             $"Транспорт: {transport}\n" +
                             $"Місце призначення: {destination}\n" +
                             $"Додаткові послуги: {services}";

            textBoxSummary.Text = summary;
        }
    }
}
