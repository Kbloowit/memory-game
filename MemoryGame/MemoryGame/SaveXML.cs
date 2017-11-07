﻿using System;
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
                writer.WriteStartElement("Players"); // Start opslaan van Players 
                writer.WriteStartElement("Player"); // Start opslaan player1
                writer.WriteString(Gamepanel.Players[0]);
                writer.WriteEndElement(); // Einde naam player 1
                writer.WriteStartElement("Player"); // Begin opslaan player 2
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
                writer.WriteStartElement("PicturesBoxes");

                //for (int i = 0; i < 16; i++)
                //{
                //    writer.WriteStartElement("Picturebox");
                //    writer.WriteString(Convert.ToString(Gamepanel.id[i]));
                //    writer.WriteEndElement();

                //}
                writer.WriteStartElement("Picturebox1");
                writer.WriteString(Convert.ToString(Gamepanel.id[0]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox2");
                writer.WriteString(Convert.ToString(Gamepanel.id[1]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox3");
                writer.WriteString(Convert.ToString(Gamepanel.id[2]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox4");
                writer.WriteString(Convert.ToString(Gamepanel.id[3]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox5");
                writer.WriteString(Convert.ToString(Gamepanel.id[4]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox6");
                writer.WriteString(Convert.ToString(Gamepanel.id[5]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox7");
                writer.WriteString(Convert.ToString(Gamepanel.id[6]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox8");
                writer.WriteString(Convert.ToString(Gamepanel.id[7]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox8");
                writer.WriteString(Convert.ToString(Gamepanel.id[8]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox10");
                writer.WriteString(Convert.ToString(Gamepanel.id[9]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox11");
                writer.WriteString(Convert.ToString(Gamepanel.id[10]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox12");
                writer.WriteString(Convert.ToString(Gamepanel.id[11]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox13");
                writer.WriteString(Convert.ToString(Gamepanel.id[12]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox14");
                writer.WriteString(Convert.ToString(Gamepanel.id[13]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox15");
                writer.WriteString(Convert.ToString(Gamepanel.id[14]));
                writer.WriteEndElement();
                writer.WriteStartElement("Picturebox16");
                writer.WriteString(Convert.ToString(Gamepanel.id[15]));
                writer.WriteEndElement();
                writer.WriteEndElement(); // Einde opslaan pictureBoxes
                writer.WriteStartElement("Achtergrond");
                writer.WriteString(Convert.ToString(Themez.Achtergrond));
                writer.WriteEndElement();
                writer.WriteEndDocument();

                // De savegame staat in de uitvoerende map (Eg. waar je je spul hebt +/bin/debug

             }

         }

        public static string LoadGame(string data)
        {
            if (!File.Exists("Memory.sav"))
                return String.Empty;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Memory.sav");


            //xDoc.SelectSingleNode("Game/Turn").InnerText


            return xDoc.SelectSingleNode(data).InnerText;
        }

        //public static List<string> Load(string data, bool array)
        //{
        //    if (!File.Exists("Memory.sav"))
        //        return null;

        //    List<string> tempStringList = new List<string>();

        //    XmlDocument xDoc = new XmlDocument();
        //    xDoc.Load("Memory.sav");

        //    //xDoc.SelectSingleNode("Game/Turn").InnerText
        //    XmlNodeList xmlList = xDoc.SelectNodes(data);

        //    foreach (XmlNode item in xmlList)
        //        tempStringList.Add(item.InnerText);

        //    return tempStringList;
        //}


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
    }
}
