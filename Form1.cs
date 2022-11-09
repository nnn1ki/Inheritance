using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {

        List<movie> moviesList = new List<movie>(); //поле по список вариантов фильмов

        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.moviesList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; i++)
            {

                switch(rnd.Next() % 3)
                {
                    case 0:
                        this.moviesList.Add(film.Generate());
                        break;

                    case 1:
                        this.moviesList.Add(film.Generate());
                        break;

                    case 2:
                        this.moviesList.Add(film.Generate());
                        break;
                }
            }
            ShowInfo();
        }


        private void ShowInfo()
        {
            int countFilm = 0;
            int countSoapOpera = 0;
            int countTelevision = 0;

            foreach (var cinimatic in this.moviesList)
            {
                if (cinimatic is film)
                {
                    countFilm++; 
                }
                
                if(cinimatic is soapOpera)
                {
                    countSoapOpera++; 
                }

                if (cinimatic is television)
                {
                    countTelevision++;
                }

                textInfo.Text = "Фильм\tСериал\tТв-программа";
                textInfo.Text += '\n';
                textInfo.Text += String.Format("{0}\t{1}\t{2}", countFilm, countSoapOpera, countTelevision);
            }
            

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.moviesList.Count == 0)
            {
                textOut.Text = "Пусто";
                return;
            }

            movie cinimatic = this.moviesList[0];
            this.moviesList.RemoveAt(0);
            
            textOut.Text = cinimatic.getInfo();
            
            ShowInfo();
        }
    }
}
