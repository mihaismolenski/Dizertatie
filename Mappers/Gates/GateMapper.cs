using AutoMapper;
using DTOs.Files;
using DTOs.Gates;
using Entities.Entities;

namespace Mappers.Gates
{
    public class GateMapper
    {
        public static GateDto MapToDto(Gate gate)
        {
            if (gate == null)
            {
                return null;
            }
            var gateDto = Mapper.Map<Gate, GateDto>(gate);

            return gateDto;
        }

        public static Gate MapToEntity(GateDto gateDto)
        {
            var gate = Mapper.Map<GateDto, Gate>(gateDto);

            return gate;
        }
    }
}
