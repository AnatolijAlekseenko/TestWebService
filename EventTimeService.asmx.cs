using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using TestWebService.Models;

namespace TestWebService
{
    /// <summary>
    /// Сводное описание для EventTimeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
   
    public class EventTimeService : System.Web.Services.WebService
    {
        /// <summary>
        ///  Непосредственно web-сервис ASMX
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public RootObject MyEventTimeService(double lat,double lng)
        {
            try
            {
                string json;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format("https://api.sunrise-sunset.org/json?lat="+lat+"&lng="+lng+" "));

                HttpWebResponse responce = (HttpWebResponse)request.GetResponse(); ;
                using (Stream stream = responce.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    json = sr.ReadToEnd();

                }
                RootObject root = JsonConvert.DeserializeObject<RootObject>(json);
                return root;
            }
            catch(Exception ex) {
                  return null;
            }
        }

    //    [WebMethod]
    //    public void TestEntity()
    //    {
    //        using (City db = new City())
    //        {
    //            // создаем два объекта User
    //            CityModel user1 = new CityModel { Name = "city1",Coord1= 36.7201600, Coord2= -4.4203400 };
    //            CityModel user2 = new CityModel { Name = "city2", Coord1 = 30.7201600, Coord2 = -6.4203400 };

    //            // добавляем их в бд
    //            db.Cities.Add(user1);
    //            db.Cities.Add(user2);
    //            db.SaveChanges();
    //            Console.WriteLine("Объекты успешно сохранены");

    //            // получаем объекты из бд и выводим на консоль
    //            var users = db.Cities;
    //            Console.WriteLine("Список объектов:");
    //            foreach (CityModel u in users)
    //            {
    //                Console.WriteLine("{0}.{1} - {3}", u.Id, u.Name, u.Coord1, u.Coord2);
    //            }
    //        }
    //        Console.Read();
    //    }

    }



    }

