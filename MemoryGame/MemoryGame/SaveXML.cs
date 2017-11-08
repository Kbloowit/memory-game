using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MemoryGame
{
    class SaveXML
    {


        
         public static void button_click ()
         {

             // Hier mee word de opmaak van het XML-bestand ingesteld
             XmlWriterSettings writerSettings = new XmlWriterSettings();
             writerSettings.NewLineOnAttributes = true; // nieuwe regel als een nieuw attribuut wordt gemaakt
             writerSettings.Indent = true;// indent (tabje in word) voor elk sub element



             using (XmlWriter writer = XmlWriter.Create("Memory.sav", writerSettings)) // hiermee wordt het document aangemaakt
             {

                 writer.WriteStartDocument(); // Hiermee wordt de writer gestart

                writer.WriteStartElement("Game"); //sub element zodat we weten waar t voor is thonk
                writer.WriteStartElement("players"); // Start opslaan van Players 
                 writer.WriteStartElement("Player1"); // Start opslaan player1
                 writer.WriteString(Gamepanel.Players[0]);
                 writer.WriteEndElement(); // Einde naam player 1
                 writer.WriteStartElement("Player2"); // Begin opslaan player 2
                 writer.WriteString(Gamepanel.Players[1]);
                 writer.WriteEndElement(); // Einde opslaan player2
                 writer.WriteEndElement(); // Einde opslaan Players 
                writer.WriteStartElement("Score"); // Start opslaan Score
                writer.WriteStartElement("ScoreP1"); // Start opslaan Score p1
                writer.WriteString(Convert.ToString(Gamepanel.countP1));
                writer.WriteEndElement(); //  Einde opslaan Score p1
                writer.WriteStartElement("ScoreP2"); // Begin opslaan Score p2
                writer.WriteString(Convert.ToString(Gamepanel.countP2));
                writer.WriteEndElement(); // Einde opslaan score p2
                writer.WriteEndElement(); // Einde opslaan score
                writer.WriteStartElement("Turn"); // Start opslaan Turn
                writer.WriteString(Gamepanel.Turn.ToString()); // turn nummer
                writer.WriteEndElement(); // Einde opslaan Turn
                writer.WriteStartElement("PictureBoxes");
                writer.WriteStartElement("Picturebox1");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[0]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox2");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[1]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox3");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[2]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox4");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[3]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox5");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[4]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox6");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[5]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox7");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[6]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox8");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[7]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox9");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[8]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox10");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[9]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox11");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[10]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox12");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[11]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox13");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[12]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox14");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[13]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox15");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[14]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox16");
                writer.WriteString(Convert.ToString(Gamepanel.pictures[15]));
                writer.WriteEndElement();
                writer.WriteEndElement(); // Einde opslaan pictureBoxes
                writer.WriteStartElement("Timer");
                writer.WriteString(Convert.ToString(Gamepanel.time));
                writer.WriteEndElement();
                writer.WriteStartElement("Turn");
                writer.WriteString(Convert.ToString(Gamepanel.Turn));
                writer.WriteEndElement();
                writer.WriteStartElement("Thema");
                writer.WriteString(Convert.ToString(Themez.Themepicked));
                writer.WriteEndElement();
                writer.WriteStartElement("Visible");
                writer.WriteStartElement("Picbox1");
                writer.WriteString(Convert.ToString(Gamepanel.visible[0]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox2");
                writer.WriteString(Convert.ToString(Gamepanel.visible[1]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox3");
                writer.WriteString(Convert.ToString(Gamepanel.visible[2]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox4");
                writer.WriteString(Convert.ToString(Gamepanel.visible[3]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox5");
                writer.WriteString(Convert.ToString(Gamepanel.visible[4]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox6");
                writer.WriteString(Convert.ToString(Gamepanel.visible[5]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox7");
                writer.WriteString(Convert.ToString(Gamepanel.visible[6]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox8");
                writer.WriteString(Convert.ToString(Gamepanel.visible[7]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox9");
                writer.WriteString(Convert.ToString(Gamepanel.visible[8]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox10");
                writer.WriteString(Convert.ToString(Gamepanel.visible[9]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox11");
                writer.WriteString(Convert.ToString(Gamepanel.visible[10]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox12");
                writer.WriteString(Convert.ToString(Gamepanel.visible[11]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox13");
                writer.WriteString(Convert.ToString(Gamepanel.visible[12]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox14");
                writer.WriteString(Convert.ToString(Gamepanel.visible[13]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox15");
                writer.WriteString(Convert.ToString(Gamepanel.visible[14]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picbox16");
                writer.WriteString(Convert.ToString(Gamepanel.visible[15]));
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();


                // De savegame staat in de uitvoerende map (Eg. waar je je spul hebt +/bin/debug









             }

         }
        public static void Compare()
        {
            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.NewLineOnAttributes = true;
            writerSettings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create("Scorecompare.xml", writerSettings)) // ongeveer hetzelfde als het deel hierboven maar dan specifiek voor de highscores vergelijken, ik maak zo een om de higscores in op te slaan
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("Compare");
                writer.WriteStartElement("Players");
                writer.WriteStartElement("Player1");
                writer.WriteString(Gamepanel.Players[0]);
                writer.WriteEndElement();
                writer.WriteStartElement("Player2");
                writer.WriteString(Gamepanel.Players[1]);
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteStartElement("Scores");
                writer.WriteStartElement("ScoreP1");
                writer.WriteString(Convert.ToString(Gamepanel.countP1));
                writer.WriteEndElement();
                writer.WriteStartElement("ScoreP2");
                writer.WriteString(Convert.ToString(Gamepanel.countP2));
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public static string Load(string data)
        {
            if (!File.Exists("Memory.sav"))
                return String.Empty;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Memory.sav");

            //xDoc.SelectSingleNode("Game/Turn").InnerText;
            SaveXML.Load("Game/players/Player1");
            SaveXML.Load("Game/players/Player2");

            SaveXML.Load("Game/Score/ScoreP1");
            SaveXML.Load("Game/Score/ScoreP2");

            SaveXML.Load("Game/Turn");

            SaveXML.Load(Convert.ToString(Gamepanel.pictures[0]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[1]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[2]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[3]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[4]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[5]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[6]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[7]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[8]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[9]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[10]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[11]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[12]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[13]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[14]));
            SaveXML.Load(Convert.ToString(Gamepanel.pictures[15]));

            return xDoc.SelectSingleNode(data).InnerText;
        }








    }
}
