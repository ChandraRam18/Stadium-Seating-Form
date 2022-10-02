namespace Stadium_Seating_Form
{
    public partial class ClassATextBox : Form
    {
        public ClassATextBox()
        {
            InitializeComponent();
        }

        private void CalculateRevenue_button_Click(object sender, EventArgs e)
        {
            try
            {
                decimal ClassACost = 15;
                decimal ClassBCost = 12;
                decimal ClassCCost = 9;

                decimal ClassATickets;
                decimal ClassBTickets;
                decimal ClassCTickets;

                ClassATickets = decimal.Parse(CAtextbox.Text);
                ClassBTickets = decimal.Parse(CBtextBox.Text);
                ClassCTickets = decimal.Parse(CCtextBox.Text);

                decimal ClassATotals;
                decimal ClassBTotals;
                decimal ClassCTotals;

                ClassATotals = ClassATickets * ClassACost;
                ClassBTotals = ClassBTickets * ClassBCost;
                ClassCTotals = ClassCTickets * ClassCCost;

                label_ClassA.Text = ClassATotals.ToString("c");
                label_ClassB.Text = ClassBTotals.ToString("c");
                label_ClassC.Text = ClassCTotals.ToString("c");

                decimal Total_Sales;
                Total_Sales = ClassATotals + ClassBTotals + ClassCTotals;
                label_total.Text = Total_Sales.ToString("c");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            CAtextbox.Text = "";
            CBtextBox.Text = "";
            CCtextBox.Text = "";

            label_ClassA.Text = "";
            label_ClassB.Text = "";
            label_ClassC.Text = "";
            label_total.Text = "";
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}