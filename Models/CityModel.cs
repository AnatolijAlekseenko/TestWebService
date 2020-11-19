using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebService.Models
{
    //Название, гео координаты города,   

    public class CityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Coord1 { get; set; } //первая координата
        public double Coord2 { get; set; } //первая координата

    }
}