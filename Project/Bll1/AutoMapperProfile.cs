using AutoMapper;
using Dto;
using Entities;
using Entities.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public  class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() {
            CreateMap<Patient, PatientDto>();
            CreateMap<PatientDto, Patient>();
            CreateMap<Corona, CoronaDto>();
            CreateMap<CoronaDto, Corona>();
        }
    }
}
