﻿using System;
using System.Collections.Generic;
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
             writerSettings.NewLineOnAttributes = true;
             writerSettings.Indent = true;



             using (XmlWriter writer = XmlWriter.Create("Savegame.sav", writerSettings)) // hiermee wordt het document aangemaakt
             {

                 writer.WriteStartDocument(); // Hiermee wordt de writer gestart

                writer.WriteStartElement("Game");
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
                writer.WriteStartElement("Plaatjenummers"); // Start opslaan Plaatjes
                foreach(int nummer in Gamepanel.pictures)
                {
                    writer.WriteString(nummer.ToString());
                }
                writer.WriteEndElement(); // Einde opslaan Plaatjes
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










    }
}
