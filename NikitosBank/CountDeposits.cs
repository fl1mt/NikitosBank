using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;

namespace NikitosBank
{
    partial class CountDeposits : Form
    {
        double incomeStable_;
        double incomeOptimal_;
        double incomeStandart_;

        double totalSumStable;
        double totalSumOptimal;
        double totalSumStandart;

        int months;
        double monthDeposit;

        string login;
        string password;

        Database db;


        public CountDeposits(double _incomeStable, double _incomeOptimal, double _incomeStandard, double _totalSumStable, double _totalSumOptimal,
            double _totalSumStandard, string _login, string  _password, int _monthsDeposit, double _monthDeposit, Database database)
        {
            InitializeComponent();
            this.login = _login;
            this.password = _password;

            incomeStable_ = _incomeStable;
            incomeOptimal_ = _incomeOptimal;
            incomeStandart_ = _incomeStandard;

            totalSumStable = _totalSumStable;
            totalSumOptimal = _totalSumOptimal;
            totalSumStandart = _totalSumStandard;

            this.months = _monthsDeposit;
            this.monthDeposit = _monthDeposit;

            incomeStableText.Text = $"{incomeStable_:C2} rub.";
            incomeOptimalText.Text = $"{incomeOptimal_:C2} rub.";
            incomeStandartText.Text = $"{incomeStandart_:C2} rub.";

            depositStableSum.Text = $"{totalSumStable:C2} rub.";
            depositOptimalSum.Text = $"{totalSumOptimal:C2} rub.";
            depositStandartSum.Text = $"{totalSumStandart:C2} rub.";

            this.db = database;
            Debug.WriteLine(months);
        }

        private void openDeposit1_Click(object sender, EventArgs e)
        {
            if(months < 6) {  return; }
            string procent = "8%";
            string fullName = db.GetFullNameByLogin(login);
            double depositSum = totalSumStable - incomeStable_;
            db.InsertDepositData(login, depositSum, months, monthDeposit, procent);
            _ = new Word(fullName, depositSum, procent, months);
            this.Close();
        }

        private void openDeposit2_Click(object sender, EventArgs e)
        {
            if (months < 6) { return; }
            string procent = "5%";
            string fullName = db.GetFullNameByLogin(login);
            double depositSum = totalSumOptimal - incomeOptimal_;
            db.InsertDepositData(login, depositSum, months, monthDeposit, procent);
            _ = new Word(fullName, depositSum, procent, months);
            this.Close();
        }

        private void openDeposit3_Click(object sender, EventArgs e)
        {
            if (months < 3) { return; }
            string procent = "6%";
            string fullName = db.GetFullNameByLogin(login);
            double depositSum = totalSumStandart - incomeStandart_;
            db.InsertDepositData(login, depositSum, months, monthDeposit, procent);
            _ = new Word(fullName, depositSum, procent, months);
            this.Close();
        }

        private void WritePDF_Click(object sender, EventArgs e)
        {
            // выписка 
            //Генерация pdf файла
            string path = AppContext.BaseDirectory + @"\jpg.jpg";
            string path2 = AppContext.BaseDirectory + @"\pdf.pdf";

            Bitmap printscreen = GetControlScreenshot(depositsPanel);
            printscreen.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);

            Document document = new Document();
            using (var stream = new FileStream(path2, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (var imageStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var image = iTextSharp.text.Image.GetInstance(imageStream);

                    PdfWriter writer = PdfWriter.GetInstance(document, stream);

                    document.SetPageSize(new iTextSharp.text.Rectangle(depositsPanel.Size.Width + document.LeftMargin + 
                        document.RightMargin, depositsPanel.Size.Height + document.TopMargin + document.BottomMargin));
                    document.Open();
                    document.Add(image);
                    document.Close();
                }
            }
            Process.Start(path2);
        }

        public Bitmap GetControlScreenshot(Control control)
        {
            Size szCurrent = control.Size;
            control.AutoSize = true;

            Bitmap bmp = new Bitmap(control.Width, control.Height);

            control.DrawToBitmap(bmp, control.ClientRectangle);

            control.AutoSize = false;
            control.Size = szCurrent;

            return bmp;
        }

    }
}
