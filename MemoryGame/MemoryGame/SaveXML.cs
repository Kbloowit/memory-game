using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MemoryGame
{
    public class SaveXML
    {

        
         public static void button_click ()
        {
            // Hier mee word de opmaak van het XML-bestand ingesteld
            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.NewLineOnAttributes = true;
            writerSettings.Indent = true;



            using (XmlWriter writer = XmlWriter.Create("Savegame.xml", writerSettings)) // Hiermee wordt het document aangemaakt
            {

                writer.WriteStartDocument(); // Hiermee wordt de writer gestart

                writer.WriteStartElement("players"); // Start opslaan van Players 
                writer.WriteStartElement("Player1");
                writer.WriteString(GamePanel.Players[0]); // naam player 1
                writer.WriteEndElement();
                writer.WriteStartElement("Player2");
                writer.WriteString(GamePanel.Players[1]); // naam player 2
                writer.WriteEndElement();
                writer.WriteStartElement("Score");
                writer.WriteStartElement("ScoreP1");
                writer.WriteString(Convert.ToString(GamePanel.countP1)); // score player 1
                writer.WriteEndElement();
                writer.WriteStartElement("ScoreP2");
                writer.WriteString(Convert.ToString(GamePanel.countP2)); // score player 2
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteStartElement("Turn");
                writer.WriteString(GamePanel.Turn.ToString()); // turn
                writer.WriteEndElement();

                writer.WriteEndDocument();

            }

            // Als je wilt zien hoe het XML-bestand eruit is komen te zien. Dan moet je na het opslaan het volgende path gebruiken
            // GitHub\memory-game\MemoryGame\MemoryGame\bin\Debug/Savegame.xml















        }

    }
}
