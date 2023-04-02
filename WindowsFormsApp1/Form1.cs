using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WindowsFormsApp1
{
    public partial class Alexophia : Form
    {

        List<Bitmap> bitmapList = new List<Bitmap>();

        Bitmap image;

        public Alexophia()
        {
            InitializeComponent();
        }



        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bitmapList.Clear();
                image = new Bitmap(dialog.FileName);
                bitmapList.Add(image);
            }

            pictureBox1.Image = image;
            pictureBox1.Refresh();

        }






        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            Bitmap tmpimg = null;
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1, Convert.ToInt32(textBox1.Text));
            //Bitmap newImage = ((MorfologyFilters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
            {
                tmpimg = newImage;
                bitmapList.Add(tmpimg);
                image = newImage;
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            button1.Visible = true;
            progressBar1.Visible = true;
            progressBar1.Value = e.ProgressPercentage;

        }




        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            button1.Visible = false;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();


        }



        int count = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (bitmapList.Count > 1)
            {
                if (count != bitmapList.Count)
                    count++;
                pictureBox1.Image = bitmapList[bitmapList.Count - count];

            }
            label1.Text = count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bitmapList.Count > 1)
            {
                if (count > 1)
                    count--;
                pictureBox1.Image = bitmapList[bitmapList.Count - count];
                label1.Text = count.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить картинку...";
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;
                sfd.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";
                sfd.ShowHelp = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(sfd.FileName);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }





        private void иверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);

        }


        private void чернобелыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new BlackAndWhite();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сепияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void яркостьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new Brightness();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void насыщенностьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new Saturation();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размытиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размытиеПоГауссуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussFilter(Convert.ToInt32(textBox1.Text));
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильрСобеляXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilterX();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильтрСобеляYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilterY();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void резкостьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильтрПрюиттаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharrFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сужениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new constriction();
            backgroundWorker1.RunWorkerAsync(filter);
            
        }

        private void растяжениеdilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Extension();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void градиентToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new GradientFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void медианныйФильрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedianFilter filter = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void идеальныйОтражательToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReflectorFilter filter = new ReflectorFilter();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void серыйМирToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GrayWorldFilter filter = new GrayWorldFilter();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void линейноеРастяжениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LinearCorrectionFilter filter = new LinearCorrectionFilter();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

    }
}
    

