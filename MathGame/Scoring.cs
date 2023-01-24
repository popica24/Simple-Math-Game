using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MathGame
{
    public class Scoring
    {
        private string filename; 
        public Scoring()
        {

            if (!File.Exists(ConfigurationManager.AppSettings["ScoreTable"]))
                File.Create(ConfigurationManager.AppSettings["ScoreTable"]);
            filename = ConfigurationManager.AppSettings["ScoreTable"];
        }
        public void Add(string username, int score, string game)
        {
           
                if (string.IsNullOrEmpty(File.ReadAllText(filename)))
                {
                    File.WriteAllText(filename, JsonConvert.SerializeObject(new PlayerModel()
                    {
                        Username = username,
                        Score = score,
                        Game = game
                    }));
                }
                else
                {
                    File.AppendAllText(filename, JsonConvert.SerializeObject(new PlayerModel()
                    {
                        Username = username,
                        Score = score,
                        Game = game
                    }));
                }
            
            
        }
        public List<PlayerModel> DisplayScore(string game)
        {
            List<PlayerModel> list = new List<PlayerModel>();
            string scoreString = File.ReadAllText(filename);
           
            JObject rss = JObject.Parse(scoreString);
            JArray Players = (JArray)rss["Game"];
            foreach(JObject o in Players)
            {
                if (o.GetValue("Game").ToString() == game)
                    list.Add(o.ToObject<PlayerModel>());
            }
            return list;
        }
    }
}
