using System;

namespace DesafioProjetoHospedagem.Exceptions
{
    public class CapacidadeDeHospedeExcedidaException : Exception
    {
        public CapacidadeDeHospedeExcedidaException(string mensagem) : base(message: mensagem){}
        
        public CapacidadeDeHospedeExcedidaException(string mensagem, Exception exception) : base(message: mensagem, innerException: exception){}
    }
}