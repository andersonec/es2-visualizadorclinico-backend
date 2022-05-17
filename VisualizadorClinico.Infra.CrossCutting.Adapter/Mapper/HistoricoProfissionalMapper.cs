using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.Mapper
{
    public class HistoricoProfissionalMapper : IHistoricoProfissionalMapper
    {
        List<HistoricoProfissionalDTO> historicoProfissionalDTOs = new List<HistoricoProfissionalDTO>();

        public HistoricoProfissional MapperToEntity(HistoricoProfissionalDTO historicoProfissionalDTO)
        {
            HistoricoProfissional historicoProfissional = new HistoricoProfissional
            {
                tipo_procedimento = historicoProfissionalDTO.tipo_procedimento,
                diagnostico = historicoProfissionalDTO.diagnostico,
                codigo = historicoProfissionalDTO.codigo,
                id_paciente = historicoProfissionalDTO.id_paciente,
                data_hora = historicoProfissionalDTO.data_hora,
                id_profissional = historicoProfissionalDTO.id_profissional,
            };

            return historicoProfissional;
        }

        public IEnumerable<HistoricoProfissionalDTO> MapperListHistoricoProfissionais(IEnumerable<HistoricoProfissional> historicoProfissionals)
        {
            foreach (var historicoProfissional in historicoProfissionals)
            {
                HistoricoProfissionalDTO historicoProfissionalDTO = new HistoricoProfissionalDTO
                {
                    id_historico = historicoProfissional.id_historico,
                    tipo_procedimento = historicoProfissional.tipo_procedimento,
                    diagnostico = historicoProfissional.diagnostico,
                    codigo = historicoProfissional.codigo,
                    id_paciente = historicoProfissional.id_paciente,
                    data_hora = historicoProfissional.data_hora,
                    id_profissional = historicoProfissional.id_profissional,
                };

                historicoProfissionalDTOs.Add(historicoProfissionalDTO);
            }

            return historicoProfissionalDTOs;
        }

        public HistoricoProfissionalDTO MapperToDTO(HistoricoProfissional historicoProfissional)
        {
            HistoricoProfissionalDTO historicoProfissionalDTO = new HistoricoProfissionalDTO
            {
                id_historico = historicoProfissional.id_historico,
                tipo_procedimento = historicoProfissional.tipo_procedimento,
                diagnostico = historicoProfissional.diagnostico,
                codigo = historicoProfissional.codigo,
                id_paciente = historicoProfissional.id_paciente,
                data_hora = historicoProfissional.data_hora,
                id_profissional = historicoProfissional.id_profissional,
            };

            return historicoProfissionalDTO;
        }
    }
}
