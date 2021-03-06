﻿using System;
using System.Configuration;
using Lattana.Bot.Manager;
using Telegram.Bot.Types;

namespace Lattana.Bot.Esecutori
{
    public static class EsecutoreInfo
    {
        public static void ComandoInfo(Message messaggio)
        {
           var versione = ConfigurationManager.AppSettings["Versione"];
            
            try
            {
                Istance.Bot.Istance.SendTextMessageAsync(messaggio.Chat.Id,
                         "Versione: " + versione + " (Alfa) \r\n" +
                          "Sito progetto \r\n" +
                          "Proverbio \r\n" +
                          "Bruto/Belo \r\n" +
                          "Poherino? \r\n" +
                          "Paolo/Bitta \r\n" +
                          "Insulta [Qualcuno] \r\n" +
                          "Fai soffrire Giulio \r\n" +
                          "Sticker \r\n" +
                          "Vai [fancuno / dormire] \r\n" +
                          "Raccogli/Raccatta [Qualcuno] \r\n" +
                          "Lattana Accogli/Vaffanculo/Mostra \r\n" +
                          "Statistiche e analisi utenti (NEW) \r\n" +
                          "Ricezione parole chiave tipo Orso/Bang \r\n"
                           );
            }
            catch (Exception)
            {
                IftttManager.SendException("Un utente probabilmente ha bloccato il bot  \n \r" + messaggio.From.Username);
                Console.WriteLine("L'utente ha bloccato il bot ( gestoreComandi)");
            }
        }
    }
}
