using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WindowsFormsApp1
namespace Inheritance
{
    public class movie
    {
        public int rating = 0;
        public static Random rnd = new Random();

        public virtual string getInfo()
        {
            var str = String.Format("\nРейтинг{0}", this.rating);
            return str;
        }

    }

    public enum Country { Russia, USA, Italia };
    public class film : movie
    {
        int yearRelease = 0;
        Country country;

        public override string getInfo()
        {
            var str = "Фильм";
            str += base.getInfo();
            str += String.Format("\nГод выпуска: {0}", this.yearRelease);
            str += String.Format("\nСтрана выпуска: {0}", this.country);

            return str;
        }

        public static movie Generate()
        {
            var rnd = new Random();
            return new film {
                rating = rnd.Next(100),
                yearRelease = rnd.Next(100) % 100,
                country = (Country)rnd.Next(3) 
            };
        }
    }

    
    public class soapOpera : movie
    {
        int totalSeries = 0;
        int totalSeasons = 0;

        public override string getInfo()
        {
            var str = "Сериал";
            str += base.getInfo();
            str += String.Format("\nКоличесво серий: {0}", this.totalSeries);
            str += String.Format("\nКоличество сезонов: {0}", this.totalSeasons);

            return str;
        }

        public static soapOpera Generate()
        {
            return new soapOpera
            {
                rating = rnd.Next(100) % 100,
                totalSeries = 250 + rnd.Next(250),
                totalSeasons = 1 + rnd.Next(10)
            };
        }
    }


    public class television : movie
    {
        int chanal = 0;

        public override string getInfo()
        {
            var str = "ТВ-программа";
            str += String.Format("\nРейтинг{0}", this.rating);
            str += String.Format("\nНомер канала: {0}", this.chanal);

            return str;
        }

        public static television Generate()
        {
            return new television
            {
                rating = rnd.Next(100),
                chanal = 1 + rnd.Next() % 20
            };
        }
    }
}