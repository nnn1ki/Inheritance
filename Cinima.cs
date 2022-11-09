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
        int rating = 0;
    }

    public class film : movie
    {
        int yearRelease = 0;
        String country;
    }

    
    public class soapOpera : movie
    {
        int rating = 0;
    }


    public class television : movie
    {
        int rating = 0;
        
    }
}