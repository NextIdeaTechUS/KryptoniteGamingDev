using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KryptoniteGaming_BatchGenerator
{
    public partial class MainForm : Form
    {

        Random r = new Random(DateTime.Now.Millisecond);
        
        private Int32 GetRandom(Int32 Range)
        {
          return Convert.ToInt32(Math.Floor( r.NextDouble() * Range));
        }
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            
            
        }

        private void GenerateRandomBatch(Int32 Range)
        {

            Int32 Pos1 = GetRandom(Range);
            Int32 Pos2 = GetRandom(Range);
            Int32 Pos3 = GetRandom(Range);

            Decimal Amount = 0;
            String Outcome = "L";

            if (Pos1 == Pos2 && Pos2 == Pos3)
            {
                Amount = (Pos1 + 1) * 10;
                Outcome = Pos1.ToString();
            }

            Utilities.DatabaseHelper.InsertNewBatch(Outcome, Amount, Pos1, Pos2, Pos3, 1);

        }

        private void btnAddSpin_Click(object sender, EventArgs e)
        {
            try
            {
                Utilities.DatabaseHelper.InsertNewBatch(txtOutcome.Text, txtAmount.Value, Convert.ToInt32(txtPos1.Value), Convert.ToInt32(txtPos2.Value), Convert.ToInt32(txtPos3.Value), 1);
                MessageBox.Show("Spin created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating spin: " + ex.Message);
            }
        }

        private void btnGenerateBatch_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < txtBatchSize.Value; i++)
                {
                    GenerateRandomBatch(11);
                }
                MessageBox.Show("Successfully generated " + txtBatchSize.Value.ToString("#,##0") + " spins.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating batch: " + ex.Message);
            }

        }

        private void btnProcessAllSpins_Click(object sender, EventArgs e)
        {
            Utilities.DatabaseHelper.MarkAllProcessed();
            MessageBox.Show("All spins marked as processed.");
        }
    }
}
