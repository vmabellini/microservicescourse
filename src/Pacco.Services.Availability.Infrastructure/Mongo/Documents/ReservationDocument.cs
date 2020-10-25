using System;

namespace Pacco.Services.Availability.Infrastructure.Mongo.Documents
{
    internal sealed class ReservationDocument
    {
        //MongoDB tem um problema de armazenar a data no formato UTC
        //Uma das maneiras de evitar isso é gravar como Timestamp ao invés de DateTime
        public int Timestamp { get; set; }

        public int Priority { get; set; }
    }
}