using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.CrossCutting.Validation.IValidations;

namespace VisualizadorClinico.Infra.CrossCutting.Validation.Validations
{
        public class PersonValidations : IPersonValidations
        {
            private readonly StatusValidation _status;

            public PersonValidations()
            {
                _status = new StatusValidation();
            }

            public StatusValidation IsValidCpf(string cpf)
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                string tempCpf;
                string digito;
                int soma;
                int resto;

                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");

                if (cpf.Length != 11)
                {
                    _status.isValid = false;
                    _status.statusMessage = "O CPF precisa conter 11 dígitos numéricos.";
                    return _status;
                }

                tempCpf = cpf.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                }

                resto = soma % 11;

                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                digito = resto.ToString();

                tempCpf = tempCpf + digito;

                soma = 0;

                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                }

                resto = soma % 11;

                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = digito + resto.ToString();

                if (cpf.EndsWith(digito) == false)
                {
                    _status.isValid = cpf.EndsWith(digito);
                    _status.statusMessage = "CPF inválido";
                }
                else
                {
                    _status.isValid = true;
                    _status.statusMessage = "";
                }
                return _status;
            }

            public StatusValidation IsValidName(string nome)
            {
                if (String.IsNullOrEmpty(nome))
                {
                    _status.isValid = false;
                    _status.statusMessage = "Por favor, digite um nome.";
                    return _status;
                }
                if (nome.Length > 50)
                {
                    _status.isValid = false;
                    _status.statusMessage = "O nome não pode conter mais de 50 caracteres.";
                    return _status;
                }
                for (int i = 0; i < nome.Length; i++)
                {
                    if (Regex.IsMatch(nome[i].ToString(), @"^[0-9]+$") == true)
                    {
                        _status.isValid = false;
                        _status.statusMessage = "O nome não pode conter caracteres especiais e nem números.";
                        return _status;
                    }
                }
                _status.isValid = true;
                _status.statusMessage = "";
                return _status;
            }

            public StatusValidation IsValidEmail(string email)
            {
                if (String.IsNullOrEmpty(email))
                {
                    _status.isValid = false;
                    _status.statusMessage = "Por favor, digite um email.";

                    return _status;
                }
                if (new EmailAddressAttribute().IsValid(email))
                {
                    _status.isValid = true;
                    _status.statusMessage = "";

                    return _status;
                }
                else
                {
                    _status.isValid = false;
                    _status.statusMessage = "Por favor, digite um email valido. Ex: 'exemplo@dominio.com' ";
                    return _status;
                }
            }
        }
    }
