﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Domain.Notificacoes
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
