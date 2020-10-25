using Convey.CQRS.Queries;
using Pacco.Services.Availability.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pacco.Services.Availability.Application.Queries
{
    //Diferente dos commands, as queries são definidas na camada application porém os handlers vão pra camada de infrastructure pois
    //eles lidam diretamente com os detalhes específicos do mongodb
    public class GetResource : IQuery<ResourceDto>
    {
        public Guid ResourceId { get; set; }
    }
}