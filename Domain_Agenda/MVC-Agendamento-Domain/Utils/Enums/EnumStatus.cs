using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Utils.Enums
{
    public enum EnumStatus
    {
        [Description("Em atendimento")]
        EmAtendimento = 1,
        [Description("Aguardando confirmação")]
        AguardandoConfirmação = 2,
        [Description("Marcado")]
        Marcado = 3,
        [Description("Atendido")]
        Atendido = 4,
        [Description("Arquivado")]
        Arquivado = 5
    }
}
