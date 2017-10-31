using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; // Moet toegevoegd worden om xml te gebruiken

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
                writer.WriteStartElement("Player1"); // Start opslaan player1
                writer.WriteString(GamePanel.Players[0]); //Naam player 1
                writer.WriteEndElement(); // Einde naam player 1
                writer.WriteStartElement("Player2"); //Start opslaan player2
                writer.WriteString(GamePanel.Players[1]); // naam player 2
                writer.WriteEndElement(); // Einde opslaan player2
                writer.WriteStartElement("Score"); // Start opslaan scores
                writer.WriteStartElement("ScoreP1"); // Score player1
                writer.WriteString(Convert.ToString(GamePanel.countP1)); // score player 1
                writer.WriteEndElement(); // Einde score player1
                writer.WriteStartElement("ScoreP2"); // Start opslaan score player2
                writer.WriteString(Convert.ToString(GamePanel.countP2)); // Score player2
                writer.WriteEndElement(); // Einde opslaan score player2
                writer.WriteEndElement(); // Einde opslaan scores
                writer.WriteStartElement("Turn"); // Start opslaan turn
                writer.WriteString(GamePanel.Turn.ToString()); // turn
                writer.WriteEndElement(); // Einde opslaan turn

                // worden nog meer aan toegevoegd, maar ben ik nog niet aan toe gekomen.

                writer.WriteEndDocument(); // Einde van het document en nu weet de writer dat hij kan stoppen

            }

            // Als je wilt zien hoe het XML-bestand eruit is komen te zien. Dan moet je na het opslaan het volgende path gebruiken
            // (locatie githubfolder)\(naam github map)\MemoryGame\MemoryGame\bin\Debug/Savegame.xml















        }

    }
}
