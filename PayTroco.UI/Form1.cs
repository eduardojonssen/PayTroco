﻿using PayTroco.Core;
using PayTroco.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayTroco.UI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e) {
            AboutBox1 aboutBox1 = new AboutBox1();
            // :/
            aboutBox1.Show();
        }

        private void UxBtnPay_Click(object sender, EventArgs e) {
            this.UxTxtChangeAmount.Text = "";
            this.UxTxtChangeAmountTotal.Text = "";

            PayTrocoManager payTrocoManager = new PayTrocoManager();

            int productAmount = int.Parse(this.UxTxtProductAmount.Text);
            int insertedAmount = int.Parse(this.UxTxtInsertedAmount.Text);

            CalculateChangeRequest calculateChangeRequest = new CalculateChangeRequest();
            calculateChangeRequest.InsertedAmountInCents = insertedAmount;
            calculateChangeRequest.ProductAmountInCents = productAmount;

            CalculateChangeResponse changeResponse = payTrocoManager.CalculateChange(calculateChangeRequest);

            string change = "";

            if (changeResponse.Success == false) {
                string outputReport = "";

                foreach (Report report in changeResponse.OperationReport) {
                    outputReport += report.ToString();
                }

                this.UxTxtChangeAmount.Text = outputReport;
                return;
            }

            foreach (Currency currency in changeResponse.CurrencyCollection) {
                foreach (KeyValuePair<int,int>kvPair in currency.CurrencyDictionary) {
                    change += kvPair.Value + " " + currency.Name + " of " + kvPair.Key + "\r\n";
                }
            }

            this.UxTxtChangeAmount.Text = change;
            this.UxTxtChangeAmountTotal.Text = changeResponse.ChangeAmount.ToString();
        }
    }
}
