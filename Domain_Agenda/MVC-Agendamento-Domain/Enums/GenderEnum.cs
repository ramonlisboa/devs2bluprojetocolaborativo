using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Enums {

    public enum GenderEnum
    {

        Masculino = 1,
        Feminino = 2,
        [Description("Não informado")]
        NaoInformado = 0
    }
}
