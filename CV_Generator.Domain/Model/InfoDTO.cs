using System;
using System.Collections.Generic;
using System.Text;

namespace CV_Generator.Domain.Model
{
    class InfoDTO
    {
        private string _nombre;
        private string _apellidos;
        private string _empresa;
        private string _email;

        public InfoDTO(string nombre, string apellidos, string empresa, string email)
        {
            this._nombre = nombre;
            this._apellidos = apellidos;
            this._empresa = empresa;
            this._email = email;
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Apellidos
        {
            get { return this._apellidos; }
            set { this._apellidos = value; }
        }

        public string Empresa
        {
            get { return this._empresa; }
            set { this._empresa = value; }
        }

        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

    }
}
