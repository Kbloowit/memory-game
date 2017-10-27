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
                writer.WriteStartElement("Player 1");
                writer.WriteString(nameP1.text); // naam player 1
                writer.WriteString(score1.text); // score player 1
                writer.WriteString(x1.text); // turn player 1
                //writer.WriteEndElement();
                writer.WriteStartElement("Player 2");
                writer.WriteString(nameP2.text); // naam player 2
                writer.WriteString(score2.text); // score player 2
                writer.WriteString(x2.text); // turn player 2
                //writer.WriteEndElement();
                writer.WriteEndElement(); // Einde van opslaan Players

                writer.WriteStartElement("Timer");
                writer.WriteString(Timertime.text); // Tekst van de timer
                writer.WriteEndElement();





                writer.WriteStartElement("cards"); // Start opslaan van de cards
                writer.WriteStartElement("card1");
                writer.WriteString(card1.image);
                writer.WriteString(card1.state);
                writer.WriteString(card1.SizeMode);
                writer.WriteString(card.tag);
                writer.WriteString(card1.BackColor);

                writer.WriteStartElement("options");
                writer.WriteString(checkbox_soundeffects.Checked);
                writer.WriteString(checkbox_backgroudmusic.Checked);
                writer.WriteString(checkbox_mute.Checked);
                writer.WriteEndElement();












            }

         }
         */
    }
}
