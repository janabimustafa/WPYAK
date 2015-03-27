using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WPYAK.Helpers;

namespace WPYAK.Model.Data
{

    //public class Rootobject
    //{
    //    public Message[] messages { get; set; }
    //    public Featuredlocation[] featuredLocations { get; set; }
    //    public Otherlocation[] otherLocations { get; set; }
    //    public string yakarma { get; set; }
    //}

    public class Message
    {
        public string messageID { get; set; }
        public string message { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string time { get; set; }
        public int numberOfLikes { get; set; }
        public string type { get; set; }
        public int comments { get; set; }
        public string posterID { get; set; }
        public string handle { get; set; }
        public object hidePin { get; set; }
        public int liked { get; set; }
        public float gmt { get; set; }
        public int reyaked { get; set; }
        public string score { get; set; }
        public int readOnly { get; set; }
        public int deliveryID { get; set; }

        public override string ToString()
        {
            return message;
        }

        public static async Task<Message[]> GetMessages()
        {
            var user = User.CurrentUser;
            var location = await Location.GetCurrentLocation();
            var url = Client.BASE_URL;
            url += string.Format("getMessages?userID={0}&lat={1}&long={2}&userLat={1}&userLong={2}&version=2.4.1&horizontalAccuracy=65.000000&verticalAccuracy=10.000000&altitude={3}&floorLevel=0&speed=-1.000000&course=-1.000000", user, location.Coordinate.Point.Position.Latitude, location.Coordinate.Point.Position.Longitude, location.Coordinate.Point.Position.Altitude);
            var response = await Client.Get(new Uri(url, UriKind.Absolute));
            var jobject = JObject.Parse(response);
            return jobject["messages"].ToObject<Message[]>();
        }
    }


}
