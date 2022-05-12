using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Infra.CrossCutting.Validation.IValidations
{
    public interface IPersonValidations
    {
        StatusValidation IsValidCpf(string cpf);
        StatusValidation IsValidName(string nome);
        StatusValidation IsValidEmail(string email);
    }
}
