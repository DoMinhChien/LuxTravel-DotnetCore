﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuxTravel.Models.Dtos;
using MediatR;

namespace LuxTravel.Api.Core.Queries
{
    public class GetDetailHotelQuery : IRequest<HotelDto>
    {
        public Guid Id { get; set; }
    }
}
