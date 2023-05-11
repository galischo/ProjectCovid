using AutoMapper;
using Dal;
using Dto;
using Entities.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class CoronaBll : ICoronaBll
    {

        ICoronaDal coronaDal;
        IMapper mapper;
        public CoronaBll(ICoronaDal coronaDal, IMapper mapper)
        {
            this.coronaDal = coronaDal;
            this.mapper = mapper;
        }

        public List<CoronaDto> getAll()
        {
            return mapper.Map<List<CoronaDto>>(this.coronaDal.GetAllCoronas());
        }
        public List<CoronaDto> getById(string id)
        {
            return mapper.Map<List<CoronaDto>>(this.coronaDal.GetCoronaById(id));
        }
    }
}
