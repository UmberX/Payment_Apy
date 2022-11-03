using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_API.Models
{
    public enum EnumStatus : int
    {
        AguardandoPagamento = 0,
        PagamentoAprovado = 1,
        EnviadoParaTransportadora = 2,
        Entregue = 3,
        Cancelada = 4
    }
}